using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE397F
{
    public partial class QLChiTietDon : Form
    {
        public QLChiTietDon()
        {
            InitializeComponent();
        }
        void docCTDDP()
        {
            //tính số ngày thuê
            DateTime ngaydat, ngaytra;
            ngaydat = DateTime.ParseExact(ThongTinDonDatPhong.NgayDat, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            ngaytra = DateTime.ParseExact(ThongTinDonDatPhong.NgayTra, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            TimeSpan songay = ngaytra - ngaydat;
            
            //đọc
            txtSoNgayThue.Text = songay.Days.ToString();
            txtIDDonDatPhong.Text = ThongTinDonDatPhong.IDDonDatPhong;
            cbxTenDV.DataSource = XuLyDuLieu.docDuLieuStored("readAllDV", new object[] { }, new string[] { });
            cbxTenKM.DataSource = XuLyDuLieu.docDuLieuStored("readAllKM", new object[] { }, new string[] { });
            cbxTenPhong.DataSource = XuLyDuLieu.docDuLieuStored("readAllPhong", new object[] { }, new string[] { });
            dgvCTDDP.DataSource = XuLyDuLieu.docDulieu("select * from ChiTietDonDatPhong where IDDonDatPhong = '" +txtIDDonDatPhong.Text.Trim() +"'").Tables[0];
        }
        private void QLChiTietDon_Load(object sender, EventArgs e)
        {
            docCTDDP();
           
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            try
            {
                
                object[] duLieu = new object[]
                 {
                        txtIDDonDatPhong.Text
                        , cbxTenKM.SelectedValue
                        , cbxTenDV.SelectedValue
                        , cbxTenPhong.SelectedValue
                        , txtSoNgayThue.Text
                        , txtSoLuongDV.Text
                        , txtSoLuongKM.Text
                        , txtDonGiaPhong.Text
                        , txtDonGiaDV.Text
                        , txtGiamGia.Text
                        , txtThanhTien.Text
                 };
                string[] thamSo = new string[]
                {
                         "@IDDonDatPhong"
                        , "@IDKhuyenMai"
                        , "@IDDichVu"
                        , "@IDPhong"
                        , "@SoNgayThue"
                        , "@SoLuongDV"
                        , "@SoLuongKM"
                        , "@DonGiaPhong"
                        , "@DonGiaDV"                 
                        , "@GiamGia"
                        , "@ThanhTien"
                };
                if (XuLyDuLieu.capNhatDuLieuStored("ThemChiTietDon", duLieu, thamSo) == 1)
                {
                    string QueryUpdate = "update Phong set "
                        + " TrangThai= 1"
                        + " where IdPhong = '" + cbxTenPhong.Text + "'";
                    if (XuLyDuLieu.CapNhatDuLieu(QueryUpdate) == 1)
                    {
                        MessageBox.Show("Phòng trả về trạng thái được thuê");
                        
                    }
                    MessageBox.Show("Thêm mới thành công!");
                    docCTDDP();
                }
                else
                {
                    MessageBox.Show("thêm mới thất bại!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            
            string QueryUpdate = "update DonDatPhong set TrangThai = 1, "
                 + "TongTien = (select sum(ThanhTien) as " + "TT" + " from ChiTietDonDatPhong where IDDonDatPhong = '"+ txtIDDonDatPhong.Text +"')"
                 + " where IDDonDatPhong = '" +txtIDDonDatPhong.Text +"'";
            if (XuLyDuLieu.CapNhatDuLieu(QueryUpdate) == 1)
            {
                string QueryUpdate1 = "update Phong set "
                        + " TrangThai= 0"
                        + " where IDPhong = '" + cbxTenPhong.Text + "'";
                if (XuLyDuLieu.CapNhatDuLieu(QueryUpdate1) == 1)
                {
                    MessageBox.Show("Phòng trả về trạng thái trống");
                }
                else
                {
                    MessageBox.Show("Phòng chưa trả về trạng thái trống");
                }
                string tongtien = "Tổng tiền hóa đơn là: ";
                string sql = @"select TongTien from DonDatPhong where IDDonDatPhong = '" + txtIDDonDatPhong.Text.Trim() + "' ";
                SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-SGKVLKK\BINH;Initial Catalog=QLKS_PM;Integrated Security=True");
                connect.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, connect);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    tongtien = tongtien + dt.Rows[0]["TongTien"].ToString().Trim();            
                }
                MessageBox.Show(tongtien);
                this.Hide();
                this.Close();
            }
            else
            {
                MessageBox.Show("Thanh toán thất bại");
            }
           
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            string query = "delete ChiTietDonDatPhong where IDCTDDP = " + txtThanhTien.Tag;
            if (XuLyDuLieu.CapNhatDuLieu(query) == 1)
            {
                MessageBox.Show("Xóa thành công!");
                docCTDDP();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }

        private void dgvCTDDP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int selectedRow = e.RowIndex;
                //Lưu tạm ID vào để hiệu chỉnh hoặc xóa
                txtThanhTien.Tag = dgvCTDDP.Rows[selectedRow].Cells["IDCTDDP"].Value.ToString();
                txtIDDonDatPhong.Text = dgvCTDDP.Rows[selectedRow].Cells["IDDonDatPhong"].Value.ToString();
                cbxTenKM.Text = dgvCTDDP.Rows[selectedRow].Cells["IDKhuyenMai"].Value.ToString();
                cbxTenDV.Text = dgvCTDDP.Rows[selectedRow].Cells["IDDichVu"].Value.ToString();
                cbxTenPhong.Text = dgvCTDDP.Rows[selectedRow].Cells["IDPhong"].Value.ToString();
                txtSoNgayThue.Text = dgvCTDDP.Rows[selectedRow].Cells["SoNgayThue"].Value.ToString();
                txtSoLuongDV.Text = dgvCTDDP.Rows[selectedRow].Cells["SoLuongDV"].Value.ToString();
                txtSoLuongKM.Text = dgvCTDDP.Rows[selectedRow].Cells["SoLuongKM"].Value.ToString();
                txtDonGiaPhong.Text = dgvCTDDP.Rows[selectedRow].Cells["DonGiaPhong"].Value.ToString();
                txtDonGiaDV.Text = dgvCTDDP.Rows[selectedRow].Cells["DonGiaDV"].Value.ToString();
                txtGiamGia.Text = dgvCTDDP.Rows[selectedRow].Cells["GiamGia"].Value.ToString();
                txtThanhTien.Text = dgvCTDDP.Rows[selectedRow].Cells["ThanhTien"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbxTenKM_TextChanged(object sender, EventArgs e)
        {
            string sql = @"select TenKM, TiLeKM from KhuyenMai where IDKhuyenMai = '" + cbxTenKM.Text.Trim() + "' ";
            SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-SGKVLKK\BINH;Initial Catalog=QLKS_PM;Integrated Security=True");
            connect.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                txtTenKM.Text = dt.Rows[0]["TenKM"].ToString().Trim();
                txtGiamGia.Text = dt.Rows[0]["TiLeKM"].ToString().Trim();
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông khuyến mãi");
            }
        }

        private void cbxTenDV_TextChanged(object sender, EventArgs e)
        {
            string sql = @"select TenDV, DonGiaDV from DichVu where IDDichVu = '" + cbxTenDV.Text.Trim() + "' ";
            SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-SGKVLKK\BINH;Initial Catalog=QLKS_PM;Integrated Security=True");
            connect.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                txtTenDV.Text = dt.Rows[0]["TenDV"].ToString().Trim();
                txtDonGiaDV.Text = dt.Rows[0]["DonGiaDV"].ToString().Trim();
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông Dịch vụ");
            }
        }

        private void cbxTenPhong_TextChanged(object sender, EventArgs e)
        {
            string sql = @"select TenPhong, DonGiaLoaiPhong from Phong p, LoaiPhong lp where p.IDLoaiPhong = lp.IDLoaiPhong and IDPhong = '" + cbxTenPhong.Text.Trim() + "' ";
            SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-SGKVLKK\BINH;Initial Catalog=QLKS_PM;Integrated Security=True");
            connect.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                txtDonGiaPhong.Text = dt.Rows[0]["DonGiaLoaiPhong"].ToString().Trim();
                txtTenPhong.Text = dt.Rows[0]["TenPhong"].ToString().Trim();
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin Phòng");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //thành tiền
            float giadv, giaphong, khuyenmai, thanhtien;
            int soluongdv, songaythue;
            soluongdv = int.Parse(txtSoLuongDV.Text);
            khuyenmai = float.Parse(txtGiamGia.Text);
            songaythue = int.Parse(txtSoNgayThue.Text);
            giadv = float.Parse(txtDonGiaDV.Text) * soluongdv;
            giaphong = float.Parse(txtDonGiaPhong.Text) * songaythue;
            thanhtien = (giadv + giaphong) * ((100 - khuyenmai) / 100);
            txtThanhTien.Text = thanhtien.ToString();
        }
    }
}
