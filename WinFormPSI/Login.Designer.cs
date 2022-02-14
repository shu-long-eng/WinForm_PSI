
namespace WinFormPSI
{
    partial class Login
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Account = new System.Windows.Forms.Label();
            this.Pwd = new System.Windows.Forms.Label();
            this.AccTextBox = new System.Windows.Forms.TextBox();
            this.PwdTextBox = new System.Windows.Forms.TextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.Msg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Account
            // 
            this.Account.AutoSize = true;
            this.Account.Location = new System.Drawing.Point(136, 138);
            this.Account.Name = "Account";
            this.Account.Size = new System.Drawing.Size(37, 15);
            this.Account.TabIndex = 0;
            this.Account.Text = "帳號";
            // 
            // Pwd
            // 
            this.Pwd.AutoSize = true;
            this.Pwd.Location = new System.Drawing.Point(139, 188);
            this.Pwd.Name = "Pwd";
            this.Pwd.Size = new System.Drawing.Size(37, 15);
            this.Pwd.TabIndex = 1;
            this.Pwd.Text = "密碼";
            // 
            // AccTextBox
            // 
            this.AccTextBox.Location = new System.Drawing.Point(179, 128);
            this.AccTextBox.Name = "AccTextBox";
            this.AccTextBox.Size = new System.Drawing.Size(100, 25);
            this.AccTextBox.TabIndex = 2;
            // 
            // PwdTextBox
            // 
            this.PwdTextBox.Location = new System.Drawing.Point(179, 188);
            this.PwdTextBox.Name = "PwdTextBox";
            this.PwdTextBox.Size = new System.Drawing.Size(100, 25);
            this.PwdTextBox.TabIndex = 3;
            this.PwdTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PwdTextBox_KeyDown);
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(170, 254);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(75, 23);
            this.LoginBtn.TabIndex = 4;
            this.LoginBtn.Text = "登入";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // Msg
            // 
            this.Msg.AutoSize = true;
            this.Msg.ForeColor = System.Drawing.Color.Red;
            this.Msg.Location = new System.Drawing.Point(139, 303);
            this.Msg.Name = "Msg";
            this.Msg.Size = new System.Drawing.Size(112, 15);
            this.Msg.TabIndex = 5;
            this.Msg.Text = "帳號或密碼錯誤";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 370);
            this.Controls.Add(this.Msg);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.PwdTextBox);
            this.Controls.Add(this.AccTextBox);
            this.Controls.Add(this.Pwd);
            this.Controls.Add(this.Account);
            this.Name = "Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Account;
        private System.Windows.Forms.Label Pwd;
        private System.Windows.Forms.TextBox AccTextBox;
        private System.Windows.Forms.TextBox PwdTextBox;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Label Msg;
    }
}

