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
    public partial class FThongKe : Form
    {
        public FThongKe()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThongKe rp = new ThongKe();
            rp.SetDataSource(dataGridView1.DataSource);
            frmThongKE rpv = new frmThongKE();
            rpv.crystalReportViewer1.ReportSource = rp;
            rpv.Show();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string query = "select KH.TenKhachHang, KH.SDT, P.MaPhong, CT.SoNgayThue, CT.DonGiaPhong, "
                          + "DV.TenDV, CT.DonGiaDV, CT.SoLuongDV, KM.TenKM, KM.TiLeKM, "
                          + "(sum(CT.DonGiaPhong*CT.SoNgayThue) + sum(CT.DonGiaDV*CT.SoLuongDV)) *KM.TiLeKM*100 as ThanhTien "
                          + "from KhachHang KH inner join DonDatPhong DDP on KH.IDKhachHang = DDP.IDKhachHang "
                          + "inner join ChiTietDonDatPhong CT on DDP.IDDonDatPhong = CT.IDDonDatPhong "
                          + "inner join DichVu DV on DV.IDDichVu = CT.IDDichVu "
                          + "inner join KhuyenMai KM on KM.IDKhuyenMai = CT.IDKhuyenMai "
                          + "inner join Phong P on P.IDPhong = CT.IDPhong "
                          + "where DDP.TrangThai = 1 and convert(varchar(8), DDP.NgayDat, 112) between  '" + dtpTuNgay.Value + "' and '" + dtpDenNgay.Value + "'"
                          + "group by KH.TenKhachHang, KH.SDT, P.MaPhong, CT.SoNgayThue, CT.DonGiaPhong, DV.TenDV, CT.DonGiaDV, CT.SoLuongDV, KM.TenKM, KM.TiLeKM "
                          ;
            dataGridView1.DataSource = XuLyDuLieu.docDulieu(query).Tables[0];
        }

        private void FThongKe_Load(object sender, EventArgs e)
        {
           /* cbxIDDonDatPhong.DataSource = XuLyDuLieu.docDuLieuStored("ReadAllDonDatPhongDaThanhToan", new object[] { }, new string[] { });*/
        }
    }
}
