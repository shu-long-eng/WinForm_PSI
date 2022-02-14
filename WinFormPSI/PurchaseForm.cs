using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormPSI.Helpers;

namespace WinFormPSI
{
    public partial class PurchaseForm : Form
    {
        static List<string> IDList = new List<string>();//IDList儲存Checkbox所選取的ID
        public PurchaseForm()
        {
            InitializeComponent();
        }

        private void Purchase_Load(object sender, EventArgs e)
        {
            //dataGridView1取得資料及設定
            this.dataGridView1.DataSource = DB.ShowPurchase();
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.Columns[1].HeaderText = "訂單編號";
            this.dataGridView1.Columns[2].HeaderText = "貨物種類";
            this.dataGridView1.Columns[3].HeaderText = "進貨數量";
            this.dataGridView1.Columns[4].HeaderText = "預計進貨時間";
            this.dataGridView1.Columns[5].HeaderText = "進貨金額";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Columns[1].ReadOnly = true;
            this.dataGridView1.Columns[2].ReadOnly = true;
            this.dataGridView1.Columns[3].ReadOnly = true;
            this.dataGridView1.Columns[4].ReadOnly = true;
            this.dataGridView1.Columns[5].ReadOnly = true;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                //獲得目前的row
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                //設定布林值給checkbox 如果有點選為true 否則 false
                row.Cells["check"].Value = Convert.ToBoolean(row.Cells["check"].EditedFormattedValue);

                //If CheckBox is checked, display Message Box.
                if (Convert.ToBoolean(row.Cells["check"].Value))//如果checkbox有點選儲存ID進IDList
                {
                    IDList.Add(row.Cells[1].Value.ToString());
                }
                if (!Convert.ToBoolean(row.Cells["check"].Value))//如果取消則從IDList中刪除
                {
                    IDList.Remove(row.Cells[1].Value.ToString());
                }
            }

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("確定要刪除嗎", "確認", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }

            if (IDList.Count == 0)
            {
                return;
            }
            DB.DeletePurchase(IDList);
            IDList.Clear();//刪除後清除IDList所儲存的ID
            this.dataGridView1.DataSource = DB.ShowPurchase();//重新取的更新後的資料
        }

        private void AddBtn_Click(object sender, EventArgs e)//新增按鈕
        {
            
            this.Hide();//隱藏本畫面
            using(PurchaseAdd purchaseAdd = new PurchaseAdd())//跳出新增訂單畫面
            {
                purchaseAdd.ShowDialog();
            }
            this.Show();//如果關閉新增訂單畫面則Show本畫面
            this.dataGridView1.DataSource = DB.ShowPurchase();//dataGridView1重新取得資料
        }

        private void print_Click(object sender, EventArgs e)//print按鈕
        {
            //跳出水晶報表畫面
            Report report = new Report();
            report.ShowDialog();
        }
    }
}
