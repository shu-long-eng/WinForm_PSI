
namespace WinFormPSI
{
    partial class PurchaseAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IDText = new System.Windows.Forms.TextBox();
            this.DateDTP = new System.Windows.Forms.DateTimePicker();
            this.Lable3 = new System.Windows.Forms.Label();
            this.TimeDTP = new System.Windows.Forms.DateTimePicker();
            this.AddProduct = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.Creator = new System.Windows.Forms.Label();
            this.Label = new System.Windows.Forms.Label();
            this.CreateTime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "訂單編號";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "進貨日期";
            // 
            // IDText
            // 
            this.IDText.Enabled = false;
            this.IDText.Location = new System.Drawing.Point(128, 56);
            this.IDText.Name = "IDText";
            this.IDText.Size = new System.Drawing.Size(100, 25);
            this.IDText.TabIndex = 2;
            // 
            // DateDTP
            // 
            this.DateDTP.CustomFormat = "";
            this.DateDTP.Location = new System.Drawing.Point(128, 101);
            this.DateDTP.Name = "DateDTP";
            this.DateDTP.Size = new System.Drawing.Size(137, 25);
            this.DateDTP.TabIndex = 3;
            // 
            // Lable3
            // 
            this.Lable3.AutoSize = true;
            this.Lable3.Location = new System.Drawing.Point(271, 108);
            this.Lable3.Name = "Lable3";
            this.Lable3.Size = new System.Drawing.Size(67, 15);
            this.Lable3.TabIndex = 4;
            this.Lable3.Text = "進貨時間";
            // 
            // TimeDTP
            // 
            this.TimeDTP.Location = new System.Drawing.Point(344, 101);
            this.TimeDTP.Name = "TimeDTP";
            this.TimeDTP.ShowUpDown = true;
            this.TimeDTP.Size = new System.Drawing.Size(106, 25);
            this.TimeDTP.TabIndex = 5;
            // 
            // AddProduct
            // 
            this.AddProduct.Location = new System.Drawing.Point(58, 144);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(36, 23);
            this.AddProduct.TabIndex = 6;
            this.AddProduct.Text = "+";
            this.AddProduct.UseVisualStyleBackColor = true;
            this.AddProduct.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete});
            this.dataGridView1.Location = new System.Drawing.Point(58, 214);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(702, 150);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Text = "刪除";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 125;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 434);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "建立者";
            // 
            // Creator
            // 
            this.Creator.AutoSize = true;
            this.Creator.Location = new System.Drawing.Point(148, 433);
            this.Creator.Name = "Creator";
            this.Creator.Size = new System.Drawing.Size(39, 15);
            this.Creator.TabIndex = 9;
            this.Creator.Text = "Label";
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(260, 433);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(67, 15);
            this.Label.TabIndex = 10;
            this.Label.Text = "建立時間";
            // 
            // CreateTime
            // 
            this.CreateTime.AutoSize = true;
            this.CreateTime.Location = new System.Drawing.Point(357, 433);
            this.CreateTime.Name = "CreateTime";
            this.CreateTime.Size = new System.Drawing.Size(0, 15);
            this.CreateTime.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(599, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "總計";
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(658, 385);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(41, 15);
            this.Total.TabIndex = 13;
            this.Total.Text = "label5";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(274, 483);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 14;
            this.Save.Text = "儲存";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(391, 483);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 15;
            this.Cancel.Text = "取消";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // PurchaseAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CreateTime);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.Creator);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AddProduct);
            this.Controls.Add(this.TimeDTP);
            this.Controls.Add(this.Lable3);
            this.Controls.Add(this.DateDTP);
            this.Controls.Add(this.IDText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PurchaseAdd";
            this.Text = "PurchaseAdd";
            this.Load += new System.EventHandler(this.PurchaseAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IDText;
        private System.Windows.Forms.DateTimePicker DateDTP;
        private System.Windows.Forms.Label Lable3;
        private System.Windows.Forms.DateTimePicker TimeDTP;
        private System.Windows.Forms.Button AddProduct;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Creator;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label CreateTime;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Cancel;
    }
}