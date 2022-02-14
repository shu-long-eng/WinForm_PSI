using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WinFormPSI.Helpers;

namespace WinFormPSI
{
    public partial class AddProduct : Form
    {
        private class ComboboxItem//儲存下拉選單資訊
        {
            public ComboboxItem(string value, string text,decimal price)
            {
                Value = value;
                Text = text;
                Price = price.ToString();
            }
            public string Value
            {
                get;
                set;
            }
            public string Text
            {
                get;
                set;
            }
            public string Price
            {
                get;
                set;
            }

            public override string ToString()//回傳下拉選單顯示項目
            {
                return Text;
            }

        }
        
        public List<Order> orderlist = new List<Order>();
        public AddProduct()
        {
            InitializeComponent();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            List<ProductInfo> list = DB.ShowProduct();//取得商品資訊
            foreach (var item in list)
            {
                this.comboBox1.Items.Add(new ComboboxItem(item.ID, item.Name,item.Price));//儲存進下拉選單
            }
            this.Total.Text = "";//隱藏總
            this.comboBox1.SelectedIndex = 0;//設定下拉選單預設選項為第一項
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)//下拉選單選擇後
        {
            //獲得選項資訊
            var item = this.comboBox1.Items[comboBox1.SelectedIndex] as ComboboxItem;
            this.Price.Text = item.Price;
            //初始化數量及小計
            this.Count.Text = "";
            this.Total.Text = "0";
        }

        private void Count_KeyPress(object sender, KeyPressEventArgs e)
        {
            //讓數量輸入框只能輸入數字
            if (((int)e.KeyChar < 48 | (int)e.KeyChar > 57) & (int)e.KeyChar != 8)
            {
                e.Handled = true;
                
            }
        }

        private void Count_KeyUp(object sender, KeyEventArgs e)
        {
            
            //預設數量為0，數量輸入框有輸入值則count設定為輸入值
            int count = 0;
            if (!string.IsNullOrEmpty(this.Count.Text))
            {
                count = Convert.ToInt32(this.Count.Text);
            }

            decimal price = Convert.ToDecimal(this.Price.Text);//單價轉型後儲存進price
            //單價*數量的結果賦予小計
            decimal total = price * count;
            this.Total.Text = total.ToString();
        }

        private void Cancel_Click(object sender, EventArgs e)//取消按鈕
        {
            var result = MessageBox.Show("確定要取消", "確認", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }
            this.Close();//關閉視窗
        }

        private void Add_Click(object sender, EventArgs e)//加入按鈕
        {
            //確認是否新增商品
            var result = MessageBox.Show("確定要新增商品", "確認", MessageBoxButtons.YesNo);
            if(result == DialogResult.No)
            {
                return;
            }

            //判斷單價或數量是否為空值
            if (string.IsNullOrEmpty(this.Price.Text)||this.Count.Text == "")
            {
                MessageBox.Show("請輸入商品及數量");
                return;
            }
            //獲得當前下拉選單資訊
            var item = this.comboBox1.Items[comboBox1.SelectedIndex] as ComboboxItem;
            //商品資訊儲存進orderlist
            orderlist.Add(new Order() { 
                ID = item.Value,
                Name = item.Text,
                Price = Convert.ToDecimal(item.Price),
                Count = Convert.ToInt32(this.Count.Text),
                Total = Convert.ToDecimal(this.Total.Text)
            });
            this.DialogResult = DialogResult.OK;//設定儲存後DialogResult的值為OK
            this.Close();//關閉頁面
        }

       
    }
}
