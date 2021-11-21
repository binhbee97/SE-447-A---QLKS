
namespace SE397F
{
    partial class QuanLyThietBi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyThietBi));
            this.cb_trangthai = new System.Windows.Forms.CheckBox();
            this.cbx_idtaikhoan = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.btnNhapLai = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_themmoi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_dongia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rtb_ghichu = new System.Windows.Forms.RichTextBox();
            this.txt_tenthietbi = new System.Windows.Forms.TextBox();
            this.IDThietBi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbx_idphong = new System.Windows.Forms.ComboBox();
            this.rtb_idphong = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_trangthai
            // 
            this.cb_trangthai.AutoSize = true;
            this.cb_trangthai.Location = new System.Drawing.Point(192, 322);
            this.cb_trangthai.Name = "cb_trangthai";
            this.cb_trangthai.Size = new System.Drawing.Size(18, 17);
            this.cb_trangthai.TabIndex = 131;
            this.cb_trangthai.UseVisualStyleBackColor = true;
            // 
            // cbx_idtaikhoan
            // 
            this.cbx_idtaikhoan.DisplayMember = "IDTaiKhoan";
            this.cbx_idtaikhoan.FormattingEnabled = true;
            this.cbx_idtaikhoan.Location = new System.Drawing.Point(192, 77);
            this.cbx_idtaikhoan.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_idtaikhoan.Name = "cbx_idtaikhoan";
            this.cbx_idtaikhoan.Size = new System.Drawing.Size(251, 28);
            this.cbx_idtaikhoan.TabIndex = 130;
            this.cbx_idtaikhoan.ValueMember = "IDTaiKhoan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 129;
            this.label2.Text = "ID Tài khoản";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 322);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 17);
            this.label7.TabIndex = 126;
            this.label7.Text = "Trạng thái";
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(192, 277);
            this.txt_soluong.Margin = new System.Windows.Forms.Padding(4);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(251, 26);
            this.txt_soluong.TabIndex = 124;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 283);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 125;
            this.label8.Text = "Số lượng";
            // 
            // btn_sua
            // 
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Image = global::SE397F.Properties.Resources.Pencil_icon;
            this.btn_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sua.Location = new System.Drawing.Point(754, 195);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(117, 39);
            this.btn_sua.TabIndex = 123;
            this.btn_sua.Text = "Chỉnh sữa";
            this.btn_sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sua.UseVisualStyleBackColor = true;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Image = global::SE397F.Properties.Resources.Windows_Close_Program_icon__1_;
            this.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoa.Location = new System.Drawing.Point(754, 128);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(117, 39);
            this.btn_xoa.TabIndex = 122;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // lblThongBao
            // 
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.ForeColor = System.Drawing.Color.Red;
            this.lblThongBao.Location = new System.Drawing.Point(217, -22);
            this.lblThongBao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(0, 20);
            this.lblThongBao.TabIndex = 118;
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapLai.Image = global::SE397F.Properties.Resources.Button_Refresh_icon;
            this.btnNhapLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhapLai.Location = new System.Drawing.Point(751, 261);
            this.btnNhapLai.Margin = new System.Windows.Forms.Padding(4);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Size = new System.Drawing.Size(119, 39);
            this.btnNhapLai.TabIndex = 114;
            this.btnNhapLai.Text = "Nhập lại";
            this.btnNhapLai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNhapLai.UseVisualStyleBackColor = true;
            this.btnNhapLai.Click += new System.EventHandler(this.btnNhapLai_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDThietBi,
            this.IDPhong,
            this.TenTB,
            this.DonGiaTB,
            this.SoLuong,
            this.TrangThai,
            this.GhiChu});
            this.dataGridView1.Location = new System.Drawing.Point(35, 435);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(835, 265);
            this.dataGridView1.TabIndex = 117;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_themmoi
            // 
            this.btn_themmoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themmoi.Image = global::SE397F.Properties.Resources.add_1_icon;
            this.btn_themmoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_themmoi.Location = new System.Drawing.Point(751, 68);
            this.btn_themmoi.Margin = new System.Windows.Forms.Padding(4);
            this.btn_themmoi.Name = "btn_themmoi";
            this.btn_themmoi.Size = new System.Drawing.Size(119, 39);
            this.btn_themmoi.TabIndex = 113;
            this.btn_themmoi.Text = "Thêm mới";
            this.btn_themmoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_themmoi.UseVisualStyleBackColor = true;
            this.btn_themmoi.Click += new System.EventHandler(this.btn_themmoi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 116;
            this.label3.Text = "ID Phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 38);
            this.label1.TabIndex = 115;
            this.label1.Text = "Quản lý thiết bị";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 183);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 134;
            this.label4.Text = "Tên thiết bị";
            // 
            // txt_dongia
            // 
            this.txt_dongia.Location = new System.Drawing.Point(192, 231);
            this.txt_dongia.Margin = new System.Windows.Forms.Padding(4);
            this.txt_dongia.Name = "txt_dongia";
            this.txt_dongia.Size = new System.Drawing.Size(251, 26);
            this.txt_dongia.TabIndex = 133;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 231);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 132;
            this.label5.Text = "Đơn giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 362);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 136;
            this.label6.Text = "Ghi chú";
            // 
            // rtb_ghichu
            // 
            this.rtb_ghichu.Location = new System.Drawing.Point(192, 345);
            this.rtb_ghichu.Name = "rtb_ghichu";
            this.rtb_ghichu.Size = new System.Drawing.Size(251, 63);
            this.rtb_ghichu.TabIndex = 137;
            this.rtb_ghichu.Text = "";
            // 
            // txt_tenthietbi
            // 
            this.txt_tenthietbi.Location = new System.Drawing.Point(192, 183);
            this.txt_tenthietbi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tenthietbi.Name = "txt_tenthietbi";
            this.txt_tenthietbi.Size = new System.Drawing.Size(251, 26);
            this.txt_tenthietbi.TabIndex = 138;
            // 
            // IDThietBi
            // 
            this.IDThietBi.DataPropertyName = "IDThietBi";
            this.IDThietBi.HeaderText = "ID Thiết bị";
            this.IDThietBi.MinimumWidth = 6;
            this.IDThietBi.Name = "IDThietBi";
            this.IDThietBi.Visible = false;
            // 
            // IDPhong
            // 
            this.IDPhong.DataPropertyName = "IDPhong";
            this.IDPhong.HeaderText = "ID Phòng";
            this.IDPhong.MinimumWidth = 6;
            this.IDPhong.Name = "IDPhong";
            // 
            // TenTB
            // 
            this.TenTB.DataPropertyName = "TenTB";
            this.TenTB.HeaderText = "Tên thiết bị";
            this.TenTB.MinimumWidth = 6;
            this.TenTB.Name = "TenTB";
            // 
            // DonGiaTB
            // 
            this.DonGiaTB.DataPropertyName = "DonGiaTB";
            this.DonGiaTB.HeaderText = "Đơn giá";
            this.DonGiaTB.MinimumWidth = 6;
            this.DonGiaTB.Name = "DonGiaTB";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TrangThai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "Trạng Thái";
            this.GhiChu.MinimumWidth = 6;
            this.GhiChu.Name = "GhiChu";
            // 
            // cbx_idphong
            // 
            this.cbx_idphong.DisplayMember = "IDPhong";
            this.cbx_idphong.FormattingEnabled = true;
            this.cbx_idphong.Location = new System.Drawing.Point(192, 119);
            this.cbx_idphong.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_idphong.Name = "cbx_idphong";
            this.cbx_idphong.Size = new System.Drawing.Size(251, 28);
            this.cbx_idphong.TabIndex = 139;
            this.cbx_idphong.ValueMember = "IDPhong";
            this.cbx_idphong.SelectedValueChanged += new System.EventHandler(this.cbx_idphong_SelectedValueChanged);
            // 
            // rtb_idphong
            // 
            this.rtb_idphong.Location = new System.Drawing.Point(192, 148);
            this.rtb_idphong.Name = "rtb_idphong";
            this.rtb_idphong.Size = new System.Drawing.Size(251, 28);
            this.rtb_idphong.TabIndex = 140;
            this.rtb_idphong.Text = "";
            // 
            // QuanLyThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 713);
            this.Controls.Add(this.rtb_idphong);
            this.Controls.Add(this.cbx_idphong);
            this.Controls.Add(this.txt_tenthietbi);
            this.Controls.Add(this.rtb_ghichu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_dongia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_trangthai);
            this.Controls.Add(this.cbx_idtaikhoan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_soluong);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.lblThongBao);
            this.Controls.Add(this.btnNhapLai);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_themmoi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "QuanLyThietBi";
            this.Text = "Quản lý thiết bị";
            this.Load += new System.EventHandler(this.QuanLyThietBi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cb_trangthai;
        private System.Windows.Forms.ComboBox cbx_idtaikhoan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Label lblThongBao;
        private System.Windows.Forms.Button btnNhapLai;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_themmoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_dongia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtb_ghichu;
        private System.Windows.Forms.TextBox txt_tenthietbi;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDThietBi;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.ComboBox cbx_idphong;
        private System.Windows.Forms.RichTextBox rtb_idphong;
    }
}