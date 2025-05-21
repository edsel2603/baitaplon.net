namespace BTL_NET
{
    partial class timkiem
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
            this.btntkkh = new System.Windows.Forms.Button();
            this.btntknv = new System.Windows.Forms.Button();
            this.btntkbao = new System.Windows.Forms.Button();
            this.panel_Body = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel_Body.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btntkbao);
            this.panel1.Controls.Add(this.btntknv);
            this.panel1.Controls.Add(this.btntkkh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(928, 68);
            this.panel1.TabIndex = 0;
            // 
            // btntkkh
            // 
            this.btntkkh.BackColor = System.Drawing.Color.Tan;
            this.btntkkh.Dock = System.Windows.Forms.DockStyle.Left;
            this.btntkkh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntkkh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntkkh.Location = new System.Drawing.Point(0, 0);
            this.btntkkh.Name = "btntkkh";
            this.btntkkh.Size = new System.Drawing.Size(301, 68);
            this.btntkkh.TabIndex = 0;
            this.btntkkh.Text = "Tìm Kiếm Khách Hàng";
            this.btntkkh.UseVisualStyleBackColor = false;
            this.btntkkh.Click += new System.EventHandler(this.btntkkh_Click);
            // 
            // btntknv
            // 
            this.btntknv.BackColor = System.Drawing.Color.Tan;
            this.btntknv.Dock = System.Windows.Forms.DockStyle.Left;
            this.btntknv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntknv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntknv.Location = new System.Drawing.Point(301, 0);
            this.btntknv.Name = "btntknv";
            this.btntknv.Size = new System.Drawing.Size(328, 68);
            this.btntknv.TabIndex = 1;
            this.btntknv.Text = "Tìm Kiếm Nhân Viên";
            this.btntknv.UseVisualStyleBackColor = false;
            this.btntknv.Click += new System.EventHandler(this.btntknv_Click);
            // 
            // btntkbao
            // 
            this.btntkbao.BackColor = System.Drawing.Color.Tan;
            this.btntkbao.Dock = System.Windows.Forms.DockStyle.Right;
            this.btntkbao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntkbao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntkbao.Location = new System.Drawing.Point(609, 0);
            this.btntkbao.Name = "btntkbao";
            this.btntkbao.Size = new System.Drawing.Size(319, 68);
            this.btntkbao.TabIndex = 2;
            this.btntkbao.Text = "Tìm Kiếm Bài Báo";
            this.btntkbao.UseVisualStyleBackColor = false;
            this.btntkbao.Click += new System.EventHandler(this.btntkbao_Click);
            // 
            // panel_Body
            // 
            this.panel_Body.Controls.Add(this.label1);
            this.panel_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Body.Location = new System.Drawing.Point(0, 68);
            this.panel_Body.Name = "panel_Body";
            this.panel_Body.Size = new System.Drawing.Size(928, 532);
            this.panel_Body.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(656, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vui Lòng Chọn Chức Năng Phía Trên Để Tìm Kiếm";
            // 
            // timkiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 600);
            this.Controls.Add(this.panel_Body);
            this.Controls.Add(this.panel1);
            this.Name = "timkiem";
            this.Text = "timkiem";
            this.Load += new System.EventHandler(this.timkiem_Load);
            this.panel1.ResumeLayout(false);
            this.panel_Body.ResumeLayout(false);
            this.panel_Body.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btntkkh;
        private System.Windows.Forms.Button btntkbao;
        private System.Windows.Forms.Button btntknv;
        private System.Windows.Forms.Panel panel_Body;
        private System.Windows.Forms.Label label1;
    }
}