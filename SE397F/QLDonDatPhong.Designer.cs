
namespace SE397F
{
    partial class QLDonDatPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLDonDatPhong));
            this.dgvDonDatPhong = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpNgayDat = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpNgayTra = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtbGhiChu = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxIDTaiKhoan = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThemMoiDon = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnChiTietDon = new System.Windows.Forms.Button();
            this.cbxIDKhachHang = new System.Windows.Forms.ComboBox();
            this.cbxTrangThai = new System.Windows.Forms.ComboBox();
            this.IDDonDatPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonDatPhong)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDonDatPhong
            // 
            this.dgvDonDatPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDonDatPhong.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDonDatPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonDatPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDDonDatPhong,
            this.IDTaiKhoan,
            this.IDKhachHang,
            this.NgayDat,
            this.NgayTra,
            this.TrangThai,
            this.GhiChu});
            this.dgvDonDatPhong.Location = new System.Drawing.Point(35, 314);
            this.dgvDonDatPhong.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDonDatPhong.Name = "dgvDonDatPhong";
            this.dgvDonDatPhong.RowHeadersWidth = 51;
            this.dgvDonDatPhong.RowTemplate.Height = 24;
            this.dgvDonDatPhong.Size = new System.Drawing.Size(1025, 224);
            this.dgvDonDatPhong.TabIndex = 72;
            this.dgvDonDatPhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDonDatPhong_CellContentClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(359, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 38);
            this.label1.TabIndex = 69;
            this.label1.Text = "Quản lý đơn đặt phòng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(34, 289);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(240, 17);
            this.label10.TabIndex = 94;
            this.label10.Text = "Danh sách đơn chưa thanh toán";
            // 
            // dtpNgayDat
            // 
            this.dtpNgayDat.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayDat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayDat.Location = new System.Drawing.Point(263, 94);
            this.dtpNgayDat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpNgayDat.Name = "dtpNgayDat";
            this.dtpNgayDat.Size = new System.Drawing.Size(222, 26);
            this.dtpNgayDat.TabIndex = 96;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(47, 94);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 17);
            this.label11.TabIndex = 95;
            this.label11.Text = "Ngày đặt";
            // 
            // dtpNgayTra
            // 
            this.dtpNgayTra.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayTra.Location = new System.Drawing.Point(710, 22);
            this.dtpNgayTra.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpNgayTra.Name = "dtpNgayTra";
            this.dtpNgayTra.Size = new System.Drawing.Size(222, 26);
            this.dtpNgayTra.TabIndex = 98;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(539, 19);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 17);
            this.label12.TabIndex = 97;
            this.label12.Text = "Ngày trả";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.cbxTrangThai);
            this.panel1.Controls.Add(this.cbxIDKhachHang);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbxIDTaiKhoan);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.rtbGhiChu);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dtpNgayTra);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.dtpNgayDat);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(35, 80);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1025, 171);
            this.panel1.TabIndex = 101;
            // 
            // rtbGhiChu
            // 
            this.rtbGhiChu.Location = new System.Drawing.Point(710, 57);
            this.rtbGhiChu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rtbGhiChu.Name = "rtbGhiChu";
            this.rtbGhiChu.Size = new System.Drawing.Size(222, 105);
            this.rtbGhiChu.TabIndex = 107;
            this.rtbGhiChu.Text = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(47, 141);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 17);
            this.label13.TabIndex = 105;
            this.label13.Text = "Trạng thái";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(539, 64);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 104;
            this.label6.Text = "Ghi chú";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 17);
            this.label3.TabIndex = 103;
            this.label3.Text = "Thông tin đơn đặt phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 108;
            this.label2.Text = "ID tài khoản";
            // 
            // cbxIDTaiKhoan
            // 
            this.cbxIDTaiKhoan.DisplayMember = "IDTaiKhoan";
            this.cbxIDTaiKhoan.FormattingEnabled = true;
            this.cbxIDTaiKhoan.Location = new System.Drawing.Point(263, 10);
            this.cbxIDTaiKhoan.Name = "cbxIDTaiKhoan";
            this.cbxIDTaiKhoan.Size = new System.Drawing.Size(222, 28);
            this.cbxIDTaiKhoan.TabIndex = 109;
            this.cbxIDTaiKhoan.ValueMember = "IDTaiKhoan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 64);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 110;
            this.label4.Text = "ID khách hàng";
            // 
            // btnThemMoiDon
            // 
            this.btnThemMoiDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMoiDon.Image = global::SE397F.Properties.Resources.add_1_icon;
            this.btnThemMoiDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemMoiDon.Location = new System.Drawing.Point(922, 249);
            this.btnThemMoiDon.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemMoiDon.Name = "btnThemMoiDon";
            this.btnThemMoiDon.Size = new System.Drawing.Size(138, 39);
            this.btnThemMoiDon.TabIndex = 104;
            this.btnThemMoiDon.Text = "Thêm mới đơn";
            this.btnThemMoiDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemMoiDon.UseVisualStyleBackColor = true;
            this.btnThemMoiDon.Click += new System.EventHandler(this.btnThemMoiDon_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Image = global::SE397F.Properties.Resources.Windows_Close_Program_icon__1_;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(956, 562);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(105, 39);
            this.btnHuy.TabIndex = 80;
            this.btnHuy.Text = "Hủy đơn";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnChiTietDon
            // 
            this.btnChiTietDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiTietDon.Image = global::SE397F.Properties.Resources.add_1_icon;
            this.btnChiTietDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChiTietDon.Location = new System.Drawing.Point(824, 562);
            this.btnChiTietDon.Margin = new System.Windows.Forms.Padding(4);
            this.btnChiTietDon.Name = "btnChiTietDon";
            this.btnChiTietDon.Size = new System.Drawing.Size(124, 39);
            this.btnChiTietDon.TabIndex = 67;
            this.btnChiTietDon.Text = "Chi tiết đơn";
            this.btnChiTietDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChiTietDon.UseVisualStyleBackColor = true;
            this.btnChiTietDon.Click += new System.EventHandler(this.btnChiTietDon_Click);
            // 
            // cbxIDKhachHang
            // 
            this.cbxIDKhachHang.DisplayMember = "IDKhachHang";
            this.cbxIDKhachHang.FormattingEnabled = true;
            this.cbxIDKhachHang.Location = new System.Drawing.Point(263, 53);
            this.cbxIDKhachHang.Name = "cbxIDKhachHang";
            this.cbxIDKhachHang.Size = new System.Drawing.Size(222, 28);
            this.cbxIDKhachHang.TabIndex = 113;
            this.cbxIDKhachHang.ValueMember = "IDKhachHang";
            // 
            // cbxTrangThai
            // 
            this.cbxTrangThai.FormattingEnabled = true;
            this.cbxTrangThai.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbxTrangThai.Location = new System.Drawing.Point(263, 130);
            this.cbxTrangThai.Name = "cbxTrangThai";
            this.cbxTrangThai.Size = new System.Drawing.Size(222, 28);
            this.cbxTrangThai.TabIndex = 114;
            // 
            // IDDonDatPhong
            // 
            this.IDDonDatPhong.DataPropertyName = "IDDonDatPhong";
            this.IDDonDatPhong.HeaderText = "IDDonDatPhong";
            this.IDDonDatPhong.MinimumWidth = 6;
            this.IDDonDatPhong.Name = "IDDonDatPhong";
            this.IDDonDatPhong.Visible = false;
            // 
            // IDTaiKhoan
            // 
            this.IDTaiKhoan.DataPropertyName = "IDTaiKhoan";
            this.IDTaiKhoan.HeaderText = "ID tài khoản";
            this.IDTaiKhoan.MinimumWidth = 6;
            this.IDTaiKhoan.Name = "IDTaiKhoan";
            this.IDTaiKhoan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IDTaiKhoan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // IDKhachHang
            // 
            this.IDKhachHang.DataPropertyName = "IDKhachHang";
            this.IDKhachHang.HeaderText = "ID khách hàng";
            this.IDKhachHang.MinimumWidth = 6;
            this.IDKhachHang.Name = "IDKhachHang";
            this.IDKhachHang.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // NgayDat
            // 
            this.NgayDat.DataPropertyName = "NgayDat";
            this.NgayDat.HeaderText = "Ngày đặt";
            this.NgayDat.MinimumWidth = 6;
            this.NgayDat.Name = "NgayDat";
            // 
            // NgayTra
            // 
            this.NgayTra.DataPropertyName = "NgayTra";
            this.NgayTra.HeaderText = "Ngày trả";
            this.NgayTra.MinimumWidth = 6;
            this.NgayTra.Name = "NgayTra";
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TrangThai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "Ghi chú";
            this.GhiChu.MinimumWidth = 6;
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GhiChu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // QLDonDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 605);
            this.Controls.Add(this.btnThemMoiDon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.dgvDonDatPhong);
            this.Controls.Add(this.btnChiTietDon);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QLDonDatPhong";
            this.Text = "QLDonDatPhong";
            this.Load += new System.EventHandler(this.QLDonDatPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonDatPhong)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.DataGridView dgvDonDatPhong;
        private System.Windows.Forms.Button btnChiTietDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpNgayDat;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpNgayTra;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtbGhiChu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThemMoiDon;
        private System.Windows.Forms.ComboBox cbxIDTaiKhoan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxIDKhachHang;
        private System.Windows.Forms.ComboBox cbxTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDDonDatPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
    }
}