using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WinFormPSI.Helpers;
using WinFormPSI.Model;

namespace WinFormPSI
{
    public partial class PurchaseAdd : Form
    {

        List<Order> list = new List<Order>();//創建list儲存訂單資訊
        
        public PurchaseAdd()
        {
            InitializeComponent();
        }

        private void PurchaseAdd_Load(object sender, EventArgs e)
        {
            this.TimeDTP.Format = DateTimePickerFormat.Custom;//設定DateTimePickerFormat為時間
            TimeDTP.CustomFormat = "HH:mm";
            //獲得訂單ID
            int countID = Helpers.DB.CountData() + 1;
            string SubID = string.Format("{0:D3}", countID);
            string ID = "ASN-" + SubID;
            this.IDText.Text = ID;


            this.CreateTime.Text = DateTime.Now.ToString();//設定創建時間為當前時間
            this.dataGridView1.Visible = false;//隱藏dataGridView1
            this.Total.Text = "";//隱藏總計
            this.Creator.Text = LoginHelper.GetLoginInfo().FirstOrDefault().Name;//獲得帳號的Name資訊儲存進Creator.Text
        }

        private void AddProduct_Click(object sender, EventArgs e)//新增按鈕
        {
            //彈出新視窗
            AddProduct form = new AddProduct();
            form.ShowDialog();
            //如果有新增商品則顯示dataGridView1
            if (form.DialogResult == DialogResult.OK)
                this.dataGridView1.Visible = true;
            //把AddProduct中的orderlist暫存到本視窗的list
            foreach (var item in form.orderlist)
            {
                list.Add(new Order() { 
                    ID = item.ID,
                    Name = item.Name,
                    Price = item.Price,
                    Count = item.Count,
                    Total = item.Total,
                   
                });
            }


            //設定dataGridView1顯示內容
            var query = list.GroupBy(item => new { item.ID, item.Name, item.Price })
                        .OrderBy(item => item.Key.ID)
                        .Select(item => new {
                            ID = item.Key.ID,
                            Name = item.Key.Name,
                            Count = item.Sum(x => x.Count),
                            Price = item.Key.Price.ToString("#,##0"),
                            Total = item.Sum(x => x.Total).ToString("#,##0"),
                        }).ToList();

            this.dataGridView1.DataSource = query;
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Columns[1].HeaderText = "商品編號";
            this.dataGridView1.Columns[2].HeaderText = "商品名稱";
            this.dataGridView1.Columns[3].HeaderText = "數量"; 
            this.dataGridView1.Columns[4].HeaderText = "單價";
            this.dataGridView1.Columns[5].HeaderText = "小計";

            decimal TotalMoney = 0;
            foreach (var item in query)
            {
                TotalMoney = TotalMoney + Convert.ToDecimal(item.Total);
            }
            this.Total.Text = TotalMoney.ToString("#,##0");

        }

        private void Cancel_Click(object sender, EventArgs e)//取消按紐
        {
            //確認畫面
            var result = MessageBox.Show("確定要是否返回", "確認", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }
            this.Close();//關閉畫面
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //確認是否要刪除
            var result = MessageBox.Show("確定要刪除", "確認", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }

            //按下dataGridView1刪除按鈕刪除資料
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                //Reference the GridView Row.
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                
                int RowIndex= row.Cells["ID"].RowIndex;
                list.RemoveAt(RowIndex);
                var query = list.GroupBy(item => new { item.ID, item.Name, item.Price })
                        .OrderBy(item => item.Key.ID)
                        .Select(item => new {
                            ID = item.Key.ID,
                            Name = item.Key.Name,
                            Count = item.Sum(x => x.Count),
                            Price = item.Key.Price.ToString("#,##0"),
                            Total = item.Sum(x => x.Total).ToString("#,##0"),
                        }).ToList();

                this.dataGridView1.DataSource = query;


            }
        }

        private void Save_Click(object sender, EventArgs e)//儲存按鈕
        {
            //確認是否要新增訂單
            var result = MessageBox.Show("確定要新增", "確認", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }

            string PurchaseID = this.IDText.Text;//訂單編號
            string Date = this.DateDTP.Text;//訂單日期
            string Time = this.TimeDTP.Text;//訂單時間
            string Creator = this.Creator.Text;//創建者
            string CreateTime = this.CreateTime.Text;//創建時間
            DateTime PurchaseDateTime = Convert.ToDateTime(Date+" "+Time);//訂單日期+訂單時間合併成完整的訂單DateTime
            
            //取得欲存進資料庫的資料
            var query = list.GroupBy(item => new { item.ID, item.Name, item.Price })
                .OrderBy(item => item.Key.ID)
                .Select(item => new
                {
                    PurchaseID = PurchaseID,
                    ID = item.Key.ID,
                    Name = item.Key.Name,
                    Count = item.Sum(x => x.Count),
                    Price = item.Key.Price,
                    Total = item.Sum(x => x.Total),
                    Creator = Creator,
                    CreateTime = CreateTime,
                    PurchaseTime = PurchaseDateTime
                });

            //如果query為空則跳出警告視窗
            if (query.Count() == 0)
            {
                MessageBox.Show("請新增商品");
                return;
            }
           
            //儲存進資料庫
            using (var context = new PSIsystemModel())
            {
                foreach (var item in query)
                {
                    var NewOrder = new Purchase()
                    {
                        ID = item.PurchaseID,
                        ProductID = item.ID,
                        Count = item.Count,
                        Date = item.PurchaseTime,
                        Total = item.Total,
                        Creator = item.Creator,
                        CreateTime = Convert.ToDateTime(item.CreateTime),
                        Isdelete = false
                    };
                    context.Purchases.Add(NewOrder);
                }
                context.SaveChanges();
            }
            this.Close();//關閉頁面

        }
    }
}
