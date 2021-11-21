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
    public partial class QuanLyDichVu : Form
    {
        public QuanLyDichVu()
        {
            InitializeComponent();
        }
        private void docDichVu()
        {
            cbx_idtaikhoan.DataSource = XuLyDuLieu.docDuLieuStored("docTatCaTaiKhoan", new object[] { }, new string[] { });
            dataGridView1.DataSource = XuLyDuLieu.docDulieu("select * from DichVu").Tables[0];
        }
        private void refresh()
        {
            txt_tendv.ResetText();
            txt_soluong.ResetText();
            txt_dongia.ResetText();
            txt_dongia.ResetText();
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            btn_themmoi.Enabled = true;
        }
        private void QuanLyDichVu_Load(object sender, EventArgs e)
        {
            refresh();
            docDichVu();
        }

        private void btn_themmoi_Click(object sender, EventArgs e)
        {
            object[] duLieu = new object[]
            {
                cbx_idtaikhoan.SelectedValue
                , txt_tendv.Text
                , dtp_batdau.Value
                , dtp_ketthuc.Value
                , txt_soluong.Text
                , txt_donvitinh.Text
                , txt_dongia.Text
            };
            string[] thamSo = new string[]
            {
                 "@IDTaiKhoan"
                , "@TenDV"
                , "@BatDau"
                , "@KetThuc"
                , "@SoLuongDV"
                , "@DonViTinh"
                , "@DonGiaDV"
            };
            if (XuLyDuLieu.capNhatDuLieuStored("ThemDV", duLieu, thamSo) == 1)
            {
                MessageBox.Show("Thêm mới thành công!");
                docDichVu();
            }
            else
            {
                MessageBox.Show("Thêm mới thất bại!");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int selectedRow = e.RowIndex;
                //Lưu tạm ID vào để hiệu chỉnh hoặc xóa
                txt_tendv.Tag = dataGridView1.Rows[selectedRow].Cells["IDDichVu"].Value.ToString();
                cbx_idtaikhoan.Text = dataGridView1.Rows[selectedRow].Cells["IDTaiKhoan"].Value.ToString();
                txt_tendv.Text = dataGridView1.Rows[selectedRow].Cells["TenDV"].Value.ToString();
                dtp_batdau.Text = dataGridView1.Rows[selectedRow].Cells["BatDau"].Value.ToString();
                dtp_ketthuc.Text = dataGridView1.Rows[selectedRow].Cells["KetThuc"].Value.ToString();
                txt_soluong.Text = dataGridView1.Rows[selectedRow].Cells["SoLuongDV"].Value.ToString();
                txt_donvitinh.Text = dataGridView1.Rows[selectedRow].Cells["DonViTinh"].Value.ToString();
                txt_dongia.Text = dataGridView1.Rows[selectedRow].Cells["DonGiaDV"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            btn_themmoi.Enabled = false;
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string query = "delete DichVu where IDDichVu = " + txt_tendv.Tag;
            if (XuLyDuLieu.CapNhatDuLieu(query) == 1)
            {
                MessageBox.Show("Xóa thành công!");
                docDichVu();
                refresh();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string query = "update DichVu set "
                + " IDTaiKhoan='" + cbx_idtaikhoan.SelectedValue + "', "
                + " TenDV=N'" + txt_tendv.Text + "', "
                + " BatDau='" + dtp_batdau.Value + "', "
                + " KetThuc='" + dtp_ketthuc.Value + "', "
                + " SoLuongDV='" + txt_soluong.Text + "' ,"
                + " DonViTinh=N'" + txt_donvitinh.Text + "' ,"
                + " DonGiaDV='" + txt_dongia.Text + "' ,"
                + " where IDDichVu = " + txt_tendv.Tag;
            if (XuLyDuLieu.CapNhatDuLieu(query) == 1)
            {
                MessageBox.Show("Chỉnh sữa thành công");
                docDichVu();
                refresh();
            }
            else
            {
                MessageBox.Show("Chỉnh sữa thất bại");
            }
        }
    }
}
