
namespace SE397F
{
    partial class QuanLyDichVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyDichVu));
            this.txt_tendv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IDDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_dongia = new System.Windows.Forms.TextBox();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_donvitinh = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtp_batdau = new System.Windows.Forms.DateTimePicker();
            this.dtp_ketthuc = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_idtaikhoan = new System.Windows.Forms.ComboBox();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btnNhapLai = new System.Windows.Forms.Button();
            this.btn_themmoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_tendv
            // 
            this.txt_tendv.Location = new System.Drawing.Point(207, 149);
            this.txt_tendv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_tendv.Name = "txt_tendv";
            this.txt_tendv.Size = new System.Drawing.Size(252, 26);
            this.txt_tendv.TabIndex = 76;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 75;
            this.label5.Text = "Kết thúc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 74;
            this.label4.Text = "Bắt đầu";
            // 
            // lblThongBao
            // 
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.ForeColor = System.Drawing.Color.Red;
            this.lblThongBao.Location = new System.Drawing.Point(233, 64);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(0, 20);
            this.lblThongBao.TabIndex = 73;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDDichVu,
            this.IDTaiKhoan,
            this.TenDV,
            this.BatDau,
            this.KetThuc,
            this.SoLuongDV,
            this.DonViTinh,
            this.DonGiaDV});
            this.dataGridView1.Location = new System.Drawing.Point(50, 458);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(835, 280);
            this.dataGridView1.TabIndex = 72;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // IDDichVu
            // 
            this.IDDichVu.DataPropertyName = "IDDichVu";
            this.IDDichVu.HeaderText = "ID dịch vụ";
            this.IDDichVu.MinimumWidth = 6;
            this.IDDichVu.Name = "IDDichVu";
            this.IDDichVu.Visible = false;
            // 
            // IDTaiKhoan
            // 
            this.IDTaiKhoan.DataPropertyName = "IDTaiKhoan";
            this.IDTaiKhoan.HeaderText = "ID Tài khoản";
            this.IDTaiKhoan.MinimumWidth = 6;
            this.IDTaiKhoan.Name = "IDTaiKhoan";
            this.IDTaiKhoan.Visible = false;
            // 
            // TenDV
            // 
            this.TenDV.DataPropertyName = "TenDV";
            this.TenDV.HeaderText = "Tên dịch vụ";
            this.TenDV.MinimumWidth = 6;
            this.TenDV.Name = "TenDV";
            // 
            // BatDau
            // 
            this.BatDau.DataPropertyName = "BatDau";
            this.BatDau.HeaderText = "Bắt đầu";
            this.BatDau.MinimumWidth = 6;
            this.BatDau.Name = "BatDau";
            // 
            // KetThuc
            // 
            this.KetThuc.DataPropertyName = "KetThuc";
            this.KetThuc.HeaderText = "Kết thúc";
            this.KetThuc.MinimumWidth = 6;
            this.KetThuc.Name = "KetThuc";
            // 
            // SoLuongDV
            // 
            this.SoLuongDV.DataPropertyName = "SoLuongDV";
            this.SoLuongDV.HeaderText = "Số lượng";
            this.SoLuongDV.MinimumWidth = 6;
            this.SoLuongDV.Name = "SoLuongDV";
            // 
            // DonViTinh
            // 
            this.DonViTinh.DataPropertyName = "DonViTinh";
            this.DonViTinh.HeaderText = "Đơn vị tính";
            this.DonViTinh.MinimumWidth = 6;
            this.DonViTinh.Name = "DonViTinh";
            // 
            // DonGiaDV
            // 
            this.DonGiaDV.DataPropertyName = "DonGiaDV";
            this.DonGiaDV.HeaderText = "Đơn giá";
            this.DonGiaDV.MinimumWidth = 6;
            this.DonGiaDV.Name = "DonGiaDV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 71;
            this.label3.Text = "Tên DV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(339, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 38);
            this.label1.TabIndex = 69;
            this.label1.Text = "Quản lý dịch vụ";
            // 
            // txt_dongia
            // 
            this.txt_dongia.Location = new System.Drawing.Point(207, 409);
            this.txt_dongia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_dongia.Name = "txt_dongia";
            this.txt_dongia.Size = new System.Drawing.Size(252, 26);
            this.txt_dongia.TabIndex = 86;
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(207, 304);
            this.txt_soluong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(252, 26);
            this.txt_soluong.TabIndex = 85;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 409);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 84;
            this.label6.Text = "Đơn giá";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(47, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 83;
            this.label7.Text = "Đơn vị tính";
            // 
            // txt_donvitinh
            // 
            this.txt_donvitinh.Location = new System.Drawing.Point(207, 352);
            this.txt_donvitinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_donvitinh.Name = "txt_donvitinh";
            this.txt_donvitinh.Size = new System.Drawing.Size(252, 26);
            this.txt_donvitinh.TabIndex = 81;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(47, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 82;
            this.label8.Text = "Số lượng";
            // 
            // dtp_batdau
            // 
            this.dtp_batdau.CustomFormat = "hh:mm:ss";
            this.dtp_batdau.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_batdau.Location = new System.Drawing.Point(207, 202);
            this.dtp_batdau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtp_batdau.Name = "dtp_batdau";
            this.dtp_batdau.Size = new System.Drawing.Size(252, 26);
            this.dtp_batdau.TabIndex = 87;
            // 
            // dtp_ketthuc
            // 
            this.dtp_ketthuc.CustomFormat = "hh:mm:ss";
            this.dtp_ketthuc.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_ketthuc.Location = new System.Drawing.Point(207, 254);
            this.dtp_ketthuc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtp_ketthuc.Name = "dtp_ketthuc";
            this.dtp_ketthuc.Size = new System.Drawing.Size(252, 26);
            this.dtp_ketthuc.TabIndex = 88;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 89;
            this.label2.Text = "ID Tài khoản";
            // 
            // cbx_idtaikhoan
            // 
            this.cbx_idtaikhoan.DisplayMember = "IDTaiKhoan";
            this.cbx_idtaikhoan.FormattingEnabled = true;
            this.cbx_idtaikhoan.Location = new System.Drawing.Point(207, 98);
            this.cbx_idtaikhoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbx_idtaikhoan.Name = "cbx_idtaikhoan";
            this.cbx_idtaikhoan.Size = new System.Drawing.Size(252, 28);
            this.cbx_idtaikhoan.TabIndex = 90;
            this.cbx_idtaikhoan.ValueMember = "IDTaiKhoan";
            // 
            // btn_sua
            // 
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Image = global::SE397F.Properties.Resources.Pencil_icon;
            this.btn_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sua.Location = new System.Drawing.Point(768, 215);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(117, 39);
            this.btn_sua.TabIndex = 80;
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
            this.btn_xoa.Location = new System.Drawing.Point(768, 149);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(117, 39);
            this.btn_xoa.TabIndex = 79;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapLai.Image = global::SE397F.Properties.Resources.Button_Refresh_icon;
            this.btnNhapLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhapLai.Location = new System.Drawing.Point(766, 281);
            this.btnNhapLai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Size = new System.Drawing.Size(119, 39);
            this.btnNhapLai.TabIndex = 68;
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
            this.btn_themmoi.Location = new System.Drawing.Point(766, 89);
            this.btn_themmoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_themmoi.Name = "btn_themmoi";
            this.btn_themmoi.Size = new System.Drawing.Size(119, 39);
            this.btn_themmoi.TabIndex = 67;
            this.btn_themmoi.Text = "Thêm mới";
            this.btn_themmoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_themmoi.UseVisualStyleBackColor = true;
            this.btn_themmoi.Click += new System.EventHandler(this.btn_themmoi_Click);
            // 
            // QuanLyDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 752);
            this.Controls.Add(this.cbx_idtaikhoan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtp_ketthuc);
            this.Controls.Add(this.dtp_batdau);
            this.Controls.Add(this.txt_dongia);
            this.Controls.Add(this.txt_soluong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_donvitinh);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.txt_tendv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblThongBao);
            this.Controls.Add(this.btnNhapLai);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_themmoi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "QuanLyDichVu";
            this.Text = "QuanLyDichVu";
            this.Load += new System.EventHandler(this.QuanLyDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.TextBox txt_tendv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblThongBao;
        private System.Windows.Forms.Button btnNhapLai;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_themmoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_dongia;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_donvitinh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtp_batdau;
        private System.Windows.Forms.DateTimePicker dtp_ketthuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn KetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaDV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_idtaikhoan;
    }
}