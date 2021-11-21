
namespace SE397F
{
    partial class QanLyLoaiPhong
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QanLyLoaiPhong));
            this.txt_tenloaiphong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IDLoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaLoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HinhAnh = new System.Windows.Forms.DataGridViewImageColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_dongia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.chọnẢnhMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaẢnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_idtaikhoan = new System.Windows.Forms.ComboBox();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNhapLai = new System.Windows.Forms.Button();
            this.btn_themmoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_tenloaiphong
            // 
            this.txt_tenloaiphong.Location = new System.Drawing.Point(246, 136);
            this.txt_tenloaiphong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_tenloaiphong.Name = "txt_tenloaiphong";
            this.txt_tenloaiphong.Size = new System.Drawing.Size(252, 26);
            this.txt_tenloaiphong.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(87, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 53;
            this.label5.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(87, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 52;
            this.label4.Text = "Đơn giá";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDLoaiPhong,
            this.IDTaiKhoan,
            this.TenLoaiPhong,
            this.DonGiaLoaiPhong,
            this.HinhAnh,
            this.SoLuong});
            this.dataGridView1.Location = new System.Drawing.Point(56, 408);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(835, 205);
            this.dataGridView1.TabIndex = 50;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // IDLoaiPhong
            // 
            this.IDLoaiPhong.DataPropertyName = "IDLoaiPhong";
            this.IDLoaiPhong.HeaderText = "ID loại phòng";
            this.IDLoaiPhong.MinimumWidth = 6;
            this.IDLoaiPhong.Name = "IDLoaiPhong";
            // 
            // IDTaiKhoan
            // 
            this.IDTaiKhoan.DataPropertyName = "IDTaiKhoan";
            this.IDTaiKhoan.HeaderText = "ID tài khoản";
            this.IDTaiKhoan.MinimumWidth = 6;
            this.IDTaiKhoan.Name = "IDTaiKhoan";
            this.IDTaiKhoan.Visible = false;
            // 
            // TenLoaiPhong
            // 
            this.TenLoaiPhong.DataPropertyName = "TenLoaiPhong";
            this.TenLoaiPhong.HeaderText = "Tên loại phòng";
            this.TenLoaiPhong.MinimumWidth = 6;
            this.TenLoaiPhong.Name = "TenLoaiPhong";
            // 
            // DonGiaLoaiPhong
            // 
            this.DonGiaLoaiPhong.DataPropertyName = "DonGiaLoaiPhong";
            this.DonGiaLoaiPhong.HeaderText = "Đơn giá loại phòng";
            this.DonGiaLoaiPhong.MinimumWidth = 6;
            this.DonGiaLoaiPhong.Name = "DonGiaLoaiPhong";
            // 
            // HinhAnh
            // 
            this.HinhAnh.DataPropertyName = "HinhAnh";
            this.HinhAnh.HeaderText = "Hình ảnh";
            this.HinhAnh.MinimumWidth = 6;
            this.HinhAnh.Name = "HinhAnh";
            this.HinhAnh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.HinhAnh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            // 
            // txt_dongia
            // 
            this.txt_dongia.Location = new System.Drawing.Point(246, 190);
            this.txt_dongia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_dongia.Name = "txt_dongia";
            this.txt_dongia.Size = new System.Drawing.Size(252, 26);
            this.txt_dongia.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 49;
            this.label3.Text = "Tên loại phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(355, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 38);
            this.label1.TabIndex = 47;
            this.label1.Text = "Quản lý loại phòng";
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(246, 241);
            this.txt_soluong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(252, 26);
            this.txt_soluong.TabIndex = 60;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chọnẢnhMớiToolStripMenuItem,
            this.xóaẢnhToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(171, 52);
            // 
            // chọnẢnhMớiToolStripMenuItem
            // 
            this.chọnẢnhMớiToolStripMenuItem.Name = "chọnẢnhMớiToolStripMenuItem";
            this.chọnẢnhMớiToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.chọnẢnhMớiToolStripMenuItem.Text = "Chọn ảnh mới";
            this.chọnẢnhMớiToolStripMenuItem.Click += new System.EventHandler(this.chọnẢnhMớiToolStripMenuItem_Click);
            // 
            // xóaẢnhToolStripMenuItem
            // 
            this.xóaẢnhToolStripMenuItem.Name = "xóaẢnhToolStripMenuItem";
            this.xóaẢnhToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.xóaẢnhToolStripMenuItem.Text = "Xóa ảnh";
            this.xóaẢnhToolStripMenuItem.Click += new System.EventHandler(this.xóaẢnhToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 48;
            this.label2.Text = "ID Tài khoản";
            // 
            // cbx_idtaikhoan
            // 
            this.cbx_idtaikhoan.DisplayMember = "IDTaiKhoan";
            this.cbx_idtaikhoan.FormattingEnabled = true;
            this.cbx_idtaikhoan.Location = new System.Drawing.Point(246, 81);
            this.cbx_idtaikhoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbx_idtaikhoan.Name = "cbx_idtaikhoan";
            this.cbx_idtaikhoan.Size = new System.Drawing.Size(252, 28);
            this.cbx_idtaikhoan.TabIndex = 63;
            this.cbx_idtaikhoan.ValueMember = "IDTaiKhoan";
            // 
            // btn_sua
            // 
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Image = global::SE397F.Properties.Resources.Pencil_icon;
            this.btn_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sua.Location = new System.Drawing.Point(406, 345);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(117, 39);
            this.btn_sua.TabIndex = 65;
            this.btn_sua.Text = "Chỉnh sữa";
            this.btn_sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Image = global::SE397F.Properties.Resources.Windows_Close_Program_icon__1_;
            this.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoa.Location = new System.Drawing.Point(290, 345);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(109, 39);
            this.btn_xoa.TabIndex = 64;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox1.Location = new System.Drawing.Point(577, 70);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(314, 275);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapLai.Image = global::SE397F.Properties.Resources.Button_Refresh_icon;
            this.btnNhapLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhapLai.Location = new System.Drawing.Point(174, 345);
            this.btnNhapLai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Size = new System.Drawing.Size(109, 39);
            this.btnNhapLai.TabIndex = 46;
            this.btnNhapLai.Text = "Nhập lại";
            this.btnNhapLai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNhapLai.UseVisualStyleBackColor = true;
            this.btnNhapLai.Click += new System.EventHandler(this.btnNhapLai_Click);
            // 
            // btn_themmoi
            // 
            this.btn_themmoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themmoi.Image = global::SE397F.Properties.Resources.add_1_icon;
            this.btn_themmoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_themmoi.Location = new System.Drawing.Point(58, 345);
            this.btn_themmoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_themmoi.Name = "btn_themmoi";
            this.btn_themmoi.Size = new System.Drawing.Size(111, 39);
            this.btn_themmoi.TabIndex = 45;
            this.btn_themmoi.Text = "Thêm mới";
            this.btn_themmoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_themmoi.UseVisualStyleBackColor = true;
            this.btn_themmoi.Click += new System.EventHandler(this.btn_themmoi_Click);
            // 
            // QanLyLoaiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(955, 650);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.cbx_idtaikhoan);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_soluong);
            this.Controls.Add(this.txt_tenloaiphong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnNhapLai);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_themmoi);
            this.Controls.Add(this.txt_dongia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "QanLyLoaiPhong";
            this.Text = "Quản lý loại phòng";
            this.Load += new System.EventHandler(this.QanLyLoaiPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_tenloaiphong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNhapLai;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_themmoi;
        private System.Windows.Forms.TextBox txt_dongia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chọnẢnhMớiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaẢnhToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDLoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaLoaiPhong;
        private System.Windows.Forms.DataGridViewImageColumn HinhAnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_idtaikhoan;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
    }
}