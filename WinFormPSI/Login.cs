using System;
using System.Windows.Forms;

namespace WinFormPSI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string Account = this.AccTextBox.Text;//Account設定為帳號輸入框的值
            string PWD = this.PwdTextBox.Text;//PWD設定為密碼輸入框的值
            if (!Helpers.LoginHelper.TryLogin(Account, PWD))//判斷登入是否成功
            {
                this.Msg.Visible = true;//如果失敗顯示錯誤訊息
            }
            else
            {
                
                this.DialogResult = DialogResult.OK;//如果成功DialogResult設定為OK
                this.Close();//關閉視窗
                

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Msg.Visible = false;//隱藏錯誤訊息
            this.PwdTextBox.PasswordChar = '*';
        }

        private void PwdTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//如果輸入的是回車鍵
            {
                this.LoginBtn_Click(sender, e);//觸發button事件
            }
        }
    }
}
