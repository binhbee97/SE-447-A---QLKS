
namespace SE397F
{
    partial class QuanLyKhuyenMai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyKhuyenMai));
            this.cbx_idtaikhoan = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_ketthuc = new System.Windows.Forms.DateTimePicker();
            this.dtp_batdau = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_tyle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.txt_tenkm = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.btnNhapLai = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_themmoi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IDKhuyenMai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TiLeKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb_trangthai = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbx_idtaikhoan
            // 
            this.cbx_idtaikhoan.DisplayMember = "IDTaiKhoan";
            this.cbx_idtaikhoan.FormattingEnabled = true;
            this.cbx_idtaikhoan.Location = new System.Drawing.Point(216, 95);
            this.cbx_idtaikhoan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbx_idtaikhoan.Name = "cbx_idtaikhoan";
            this.cbx_idtaikhoan.Size = new System.Drawing.Size(251, 28);
            this.cbx_idtaikhoan.TabIndex = 111;
            this.cbx_idtaikhoan.ValueMember = "IDTaiKhoan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 110;
            this.label2.Text = "ID Tài khoản";
            // 
            // dtp_ketthuc
            // 
            this.dtp_ketthuc.CustomFormat = "dd/MM/yyyy";
            this.dtp_ketthuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ketthuc.Location = new System.Drawing.Point(216, 251);
            this.dtp_ketthuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp_ketthuc.Name = "dtp_ketthuc";
            this.dtp_ketthuc.Size = new System.Drawing.Size(251, 26);
            this.dtp_ketthuc.TabIndex = 109;
            // 
            // dtp_batdau
            // 
            this.dtp_batdau.CustomFormat = "dd/MM/yyyy";
            this.dtp_batdau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_batdau.Location = new System.Drawing.Point(216, 200);
            this.dtp_batdau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp_batdau.Name = "dtp_batdau";
            this.dtp_batdau.Size = new System.Drawing.Size(251, 26);
            this.dtp_batdau.TabIndex = 108;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(56, 350);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 104;
            this.label7.Text = "Tỷ lệ";
            // 
            // txt_tyle
            // 
            this.txt_tyle.Location = new System.Drawing.Point(216, 350);
            this.txt_tyle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_tyle.Name = "txt_tyle";
            this.txt_tyle.Size = new System.Drawing.Size(251, 26);
            this.txt_tyle.TabIndex = 102;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(56, 301);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 17);
            this.label8.TabIndex = 103;
            this.label8.Text = "Trạng thái";
            // 
            // btn_sua
            // 
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Image = global::SE397F.Properties.Resources.Pencil_icon;
            this.btn_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sua.Location = new System.Drawing.Point(778, 213);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(117, 39);
            this.btn_sua.TabIndex = 101;
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
            this.btn_xoa.Location = new System.Drawing.Point(778, 146);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(117, 39);
            this.btn_xoa.TabIndex = 100;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // txt_tenkm
            // 
            this.txt_tenkm.Location = new System.Drawing.Point(216, 146);
            this.txt_tenkm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_tenkm.Name = "txt_tenkm";
            this.txt_tenkm.Size = new System.Drawing.Size(251, 26);
            this.txt_tenkm.TabIndex = 99;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 251);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 98;
            this.label5.Text = "Kết thúc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 200);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 97;
            this.label4.Text = "Bắt đầu";
            // 
            // lblThongBao
            // 
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.ForeColor = System.Drawing.Color.Red;
            this.lblThongBao.Location = new System.Drawing.Point(242, 61);
            this.lblThongBao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(0, 20);
            this.lblThongBao.TabIndex = 96;
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapLai.Image = global::SE397F.Properties.Resources.Button_Refresh_icon;
            this.btnNhapLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhapLai.Location = new System.Drawing.Point(775, 279);
            this.btnNhapLai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Size = new System.Drawing.Size(119, 39);
            this.btnNhapLai.TabIndex = 92;
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
            this.IDKhuyenMai,
            this.IDTaiKhoan,
            this.TenKM,
            this.BatDau,
            this.KetThuc,
            this.TrangThai,
            this.TiLeKM});
            this.dataGridView1.Location = new System.Drawing.Point(59, 438);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(835, 280);
            this.dataGridView1.TabIndex = 95;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_themmoi
            // 
            this.btn_themmoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themmoi.Image = global::SE397F.Properties.Resources.add_1_icon;
            this.btn_themmoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_themmoi.Location = new System.Drawing.Point(775, 86);
            this.btn_themmoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_themmoi.Name = "btn_themmoi";
            this.btn_themmoi.Size = new System.Drawing.Size(119, 39);
            this.btn_themmoi.TabIndex = 91;
            this.btn_themmoi.Text = "Thêm mới";
            this.btn_themmoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_themmoi.UseVisualStyleBackColor = true;
            this.btn_themmoi.Click += new System.EventHandler(this.btn_themmoi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 94;
            this.label3.Text = "Tên Khuyễn mãi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(342, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 38);
            this.label1.TabIndex = 93;
            this.label1.Text = "Quản lý khuyễn mãi";
            // 
            // IDKhuyenMai
            // 
            this.IDKhuyenMai.DataPropertyName = "IDKhuyenMai";
            this.IDKhuyenMai.HeaderText = "ID khuyến mãi";
            this.IDKhuyenMai.MinimumWidth = 6;
            this.IDKhuyenMai.Name = "IDKhuyenMai";
            this.IDKhuyenMai.Visible = false;
            // 
            // IDTaiKhoan
            // 
            this.IDTaiKhoan.DataPropertyName = "IDTaiKhoan";
            this.IDTaiKhoan.HeaderText = "ID Tài khoản";
            this.IDTaiKhoan.MinimumWidth = 6;
            this.IDTaiKhoan.Name = "IDTaiKhoan";
            this.IDTaiKhoan.Visible = false;
            // 
            // TenKM
            // 
            this.TenKM.DataPropertyName = "TenKM";
            this.TenKM.HeaderText = "Tên khuyến mãi";
            this.TenKM.MinimumWidth = 6;
            this.TenKM.Name = "TenKM";
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
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TrangThai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // TiLeKM
            // 
            this.TiLeKM.DataPropertyName = "TiLeKM";
            this.TiLeKM.HeaderText = "Tỷ lệ khuyến mãi";
            this.TiLeKM.MinimumWidth = 6;
            this.TiLeKM.Name = "TiLeKM";
            // 
            // cb_trangthai
            // 
            this.cb_trangthai.AutoSize = true;
            this.cb_trangthai.Location = new System.Drawing.Point(216, 301);
            this.cb_trangthai.Name = "cb_trangthai";
            this.cb_trangthai.Size = new System.Drawing.Size(18, 17);
            this.cb_trangthai.TabIndex = 112;
            this.cb_trangthai.UseVisualStyleBackColor = true;
            // 
            // QuanLyKhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 750);
            this.Controls.Add(this.cb_trangthai);
            this.Controls.Add(this.cbx_idtaikhoan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtp_ketthuc);
            this.Controls.Add(this.dtp_batdau);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_tyle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.txt_tenkm);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "QuanLyKhuyenMai";
            this.Text = "QuanLyKhuyenMai";
            this.Load += new System.EventHandler(this.QuanLyKhuyenMai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_idtaikhoan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_ketthuc;
        private System.Windows.Forms.DateTimePicker dtp_batdau;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_tyle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.TextBox txt_tenkm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblThongBao;
        private System.Windows.Forms.Button btnNhapLai;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_themmoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDKhuyenMai;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKM;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn KetThuc;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiLeKM;
        private System.Windows.Forms.CheckBox cb_trangthai;
    }
}