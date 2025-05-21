namespace BTL_NET
{
    partial class quanlykhachhang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBaiviet = new System.Windows.Forms.Button();
            this.btnTtkh = new System.Windows.Forms.Button();
            this.panel_Body = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel_Body.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.btnBaiviet);
            this.panel1.Controls.Add(this.btnTtkh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(928, 65);
            this.panel1.TabIndex = 0;
            // 
            // btnBaiviet
            // 
            this.btnBaiviet.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBaiviet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaiviet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaiviet.Location = new System.Drawing.Point(451, 0);
            this.btnBaiviet.Name = "btnBaiviet";
            this.btnBaiviet.Size = new System.Drawing.Size(477, 65);
            this.btnBaiviet.TabIndex = 1;
            this.btnBaiviet.Text = "Bài Viết";
            this.btnBaiviet.UseVisualStyleBackColor = true;
            this.btnBaiviet.Click += new System.EventHandler(this.btnBaiviet_Click);
            // 
            // btnTtkh
            // 
            this.btnTtkh.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTtkh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTtkh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTtkh.Location = new System.Drawing.Point(0, 0);
            this.btnTtkh.Name = "btnTtkh";
            this.btnTtkh.Size = new System.Drawing.Size(468, 65);
            this.btnTtkh.TabIndex = 0;
            this.btnTtkh.Text = "Thông tin Khách Hàng";
            this.btnTtkh.UseVisualStyleBackColor = true;
            this.btnTtkh.Click += new System.EventHandler(this.btnTtkh_Click);
            // 
            // panel_Body
            // 
            this.panel_Body.BackColor = System.Drawing.Color.Silver;
            this.panel_Body.Controls.Add(this.label3);
            this.panel_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Body.Location = new System.Drawing.Point(0, 65);
            this.panel_Body.Name = "panel_Body";
            this.panel_Body.Size = new System.Drawing.Size(928, 535);
            this.panel_Body.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(155, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(580, 82);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chào mừng bạn đến với \r\nHệ thống Quản lý Hợp đồng Quảng Cáo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quanlykhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 600);
            this.Controls.Add(this.panel_Body);
            this.Controls.Add(this.panel1);
            this.Name = "quanlykhachhang";
            this.Text = "quanlynhanvien";
            this.Load += new System.EventHandler(this.quanlykhachhang_Load);
            this.panel1.ResumeLayout(false);
            this.panel_Body.ResumeLayout(false);
            this.panel_Body.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_Body;
        private System.Windows.Forms.Button btnTtkh;
        private System.Windows.Forms.Button btnBaiviet;
        private System.Windows.Forms.Label label3;
    }
}