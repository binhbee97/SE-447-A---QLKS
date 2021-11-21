
namespace SE397F
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmt_tentaikhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmt__qllp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmt_qlp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmt_qlkm = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmt_qldv = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmt_qltb = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmt_qlddp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmt_thongke = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmt_tentaikhoan,
            this.tsmt__qllp,
            this.tsmt_qlp,
            this.tsmt_qlkm,
            this.tsmt_qldv,
            this.tsmt_qltb,
            this.tsmt_qlddp,
            this.tsmt_thongke});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(239, 450);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmt_tentaikhoan
            // 
            this.tsmt_tentaikhoan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsmt_tentaikhoan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýTàiKhoảnToolStripMenuItem});
            this.tsmt_tentaikhoan.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmt_tentaikhoan.ForeColor = System.Drawing.Color.Black;
            this.tsmt_tentaikhoan.Name = "tsmt_tentaikhoan";
            this.tsmt_tentaikhoan.Size = new System.Drawing.Size(145, 29);
            this.tsmt_tentaikhoan.Text = "Tên tài khoản";
            // 
            // tsmt__qllp
            // 
            this.tsmt__qllp.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmt__qllp.Name = "tsmt__qllp";
            this.tsmt__qllp.Size = new System.Drawing.Size(195, 29);
            this.tsmt__qllp.Text = "Quản lý loại phòng";
            this.tsmt__qllp.Click += new System.EventHandler(this.tsmt__qllp_Click);
            // 
            // tsmt_qlp
            // 
            this.tsmt_qlp.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmt_qlp.Name = "tsmt_qlp";
            this.tsmt_qlp.Size = new System.Drawing.Size(158, 29);
            this.tsmt_qlp.Text = "Quản lý phòng";
            this.tsmt_qlp.Click += new System.EventHandler(this.tsmt_qlp_Click);
            // 
            // tsmt_qlkm
            // 
            this.tsmt_qlkm.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmt_qlkm.Name = "tsmt_qlkm";
            this.tsmt_qlkm.Size = new System.Drawing.Size(202, 29);
            this.tsmt_qlkm.Text = "Quản lý khuyến mãi";
            this.tsmt_qlkm.Click += new System.EventHandler(this.tsmt_qlkm_Click);
            // 
            // tsmt_qldv
            // 
            this.tsmt_qldv.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmt_qldv.Name = "tsmt_qldv";
            this.tsmt_qldv.Size = new System.Drawing.Size(163, 29);
            this.tsmt_qldv.Text = "Quản lý dịch vụ";
            this.tsmt_qldv.Click += new System.EventHandler(this.tsmt_qldv_Click);
            // 
            // tsmt_qltb
            // 
            this.tsmt_qltb.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmt_qltb.Name = "tsmt_qltb";
            this.tsmt_qltb.Size = new System.Drawing.Size(161, 29);
            this.tsmt_qltb.Text = "Quản lý thiết bị";
            this.tsmt_qltb.Click += new System.EventHandler(this.tsmt_qltb_Click);
            // 
            // tsmt_qlddp
            // 
            this.tsmt_qlddp.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmt_qlddp.Name = "tsmt_qlddp";
            this.tsmt_qlddp.Size = new System.Drawing.Size(233, 29);
            this.tsmt_qlddp.Text = "Quản lý đơn đặt phòng";
            // 
            // tsmt_thongke
            // 
            this.tsmt_thongke.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmt_thongke.Name = "tsmt_thongke";
            this.tsmt_thongke.Size = new System.Drawing.Size(110, 29);
            this.tsmt_thongke.Text = "Thống kê";
            this.tsmt_thongke.Click += new System.EventHandler(this.tsmt_thongke_Click);
            // 
            // quảnLýTàiKhoảnToolStripMenuItem
            // 
            this.quảnLýTàiKhoảnToolStripMenuItem.Name = "quảnLýTàiKhoảnToolStripMenuItem";
            this.quảnLýTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(254, 30);
            this.quảnLýTàiKhoảnToolStripMenuItem.Text = "Quản lý tài khoản";
            this.quảnLýTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.quảnLýTàiKhoảnToolStripMenuItem_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::SE397F.Properties.Resources._198735465_492577612071144_650423710335454504_n;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmt_tentaikhoan;
        private System.Windows.Forms.ToolStripMenuItem tsmt__qllp;
        private System.Windows.Forms.ToolStripMenuItem tsmt_qlp;
        private System.Windows.Forms.ToolStripMenuItem tsmt_qlkm;
        private System.Windows.Forms.ToolStripMenuItem tsmt_qldv;
        private System.Windows.Forms.ToolStripMenuItem tsmt_qltb;
        private System.Windows.Forms.ToolStripMenuItem tsmt_qlddp;
        private System.Windows.Forms.ToolStripMenuItem tsmt_thongke;
        private System.Windows.Forms.ToolStripMenuItem quảnLýTàiKhoảnToolStripMenuItem;
    }
}