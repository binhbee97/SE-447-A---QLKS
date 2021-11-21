using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE397F
{
    public partial class QLDonDatPhong : Form
    {
       
        public QLDonDatPhong()
        {
            InitializeComponent();
        }

        void docAllDonDatPhong()
        {
            /*string query = "select KH.TenKhachHang, KH.SDT, KH.NgaySinh, KH.SoCMND, case when GioiTinh = 1 then 'Nam' else N'Nữ' end as GT " 
                          + ", KH.DiaChi, DDP.NgayDat, DDP.NgayTra, P.TenPhong, P.TrangThai, CT.DonGiaPhong, "
                          + "DV.TenDV, CT.DonGiaDV, CT.SoLuongDV,KM.TiLeKM, "
                          + "(sum(CT.DonGiaPhong*CT.SoNgayThue) + sum(CT.DonGiaDV*CT.SoLuongDV)) *KM.TiLeKM*100 as ThanhTien "
                          + "from KhachHang KH inner join DonDatPhong DDP on KH.IDKhachHang = DDP.IDKhachHang "
                          + "inner join ChiTietDonDatPhong CT on DDP.IDDonDatPhong = CT.IDDonDatPhong "
                          + "inner join DichVu DV on DV.IDDichVu = CT.IDDichVu "
                          + "inner join KhuyenMai KM on KM.IDKhuyenMai = CT.IDKhuyenMai "
                          + "inner join Phong P on P.IDPhong = CT.IDPhong "
                          + "where DDP.TrangThai = 1"
                          + "group by KH.TenKhachHang, KH.SDT, KH.NgaySinh, KH.SoCMND, GioiTinh, KH.DiaChi, DDP.NgayDat, DDP.NgayTra,P.TenPhong, P.TrangThai ,CT.DonGiaPhong, DV.TenDV, CT.DonGiaDV, CT.SoLuongDV, KM.TiLeKM "
                          ; ;*/
            /* dgvChiTietDatPhong.DataSource = XuLyDuLieu.docDulieu(query).Tables[0];*/
            
            cbxIDKhachHang.DataSource = XuLyDuLieu.docDuLieuStored("readAllKH", new object[] { }, new string[] { });
            cbxIDTaiKhoan.DataSource = XuLyDuLieu.docDuLieuStored("docTatCaTaiKhoan", new object[] { }, new string[] { });
            dgvDonDatPhong.DataSource = XuLyDuLieu.docDulieu("select * from DonDatPhong where TrangThai = 0").Tables[0];
        }

        private void QLDonDatPhong_Load(object sender, EventArgs e)
        {
            cbxIDKhachHang.Text = ThongTinKhachHang.IDKhachHang;
            docAllDonDatPhong();
        }

        private void dgvDonDatPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int selectedRow = e.RowIndex;
                //Lưu tạm ID vào để hiệu chỉnh hoặc xóa
                rtbGhiChu.Tag = dgvDonDatPhong.Rows[selectedRow].Cells["IDDonDatPhong"].Value.ToString();
                ThongTinDonDatPhong.IDDonDatPhong = (string)rtbGhiChu.Tag;
                cbxIDTaiKhoan.Text = dgvDonDatPhong.Rows[selectedRow].Cells["IDTaiKhoan"].Value.ToString();
                cbxIDKhachHang.Text = dgvDonDatPhong.Rows[selectedRow].Cells["IDKhachHang"].Value.ToString();   
                dtpNgayDat.Text = dgvDonDatPhong.Rows[selectedRow].Cells["NgayDat"].Value.ToString();
                dtpNgayTra.Text = dgvDonDatPhong.Rows[selectedRow].Cells["NgayTra"].Value.ToString();
                
                rtbGhiChu.Text = dgvDonDatPhong.Rows[selectedRow].Cells["GhiChu"].Value.ToString();
                ThongTinDonDatPhong.NgayDat = dtpNgayDat.Text;
                ThongTinDonDatPhong.NgayTra = dtpNgayTra.Text;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThemMoiDon_Click(object sender, EventArgs e)
        {
            try
            {
                object[] duLieu = new object[]
                {
                cbxIDTaiKhoan.SelectedValue
                , cbxIDKhachHang.SelectedValue
                , dtpNgayDat.Value
                , dtpNgayTra.Value
                , cbxTrangThai.SelectedItem
                , rtbGhiChu.Text
                 };
                string[] thamSo = new string[]
                {
                 "@IDTaiKhoan"
                , "@IDKhachHang"
                , "@NgayDat"
                , "@NgayTra"
                , "@TrangThai"
                , "@GhiChu"
                };
                if (XuLyDuLieu.capNhatDuLieuStored("ThemDonDatPhong", duLieu, thamSo) == 1)
                {
                    MessageBox.Show("Thêm mới thành công!");
                    docAllDonDatPhong();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            string query = "delete DonDatPhong where IDDonDatPhong = " + rtbGhiChu.Tag;
            if (XuLyDuLieu.CapNhatDuLieu(query) == 1)
            {
                MessageBox.Show("Hủy thành công!");
                docAllDonDatPhong();
            }
            else
            {
                MessageBox.Show("Hủy thất bại!");
            }
        }

        private void btnChiTietDon_Click(object sender, EventArgs e)
        {
            ThongTinDonDatPhong.IDDonDatPhong = (string)rtbGhiChu.Tag;
            ThongTinDonDatPhong.NgayDat = dtpNgayDat.Text;
            ThongTinDonDatPhong.NgayTra = dtpNgayTra.Text;
            
            QLChiTietDon qlctd = new QLChiTietDon();
            this.Hide();
            qlctd.ShowDialog();
            this.Close();
        }
    }
}
