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
    public partial class QuanLyKhuyenMai : Form
    {
        public QuanLyKhuyenMai()
        {
            InitializeComponent();
        }
        private void refresh()
        {
            txt_tenkm.ResetText();
            txt_tyle.ResetText();
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            btn_themmoi.Enabled = true;
        }
        private void docKM()
        {
            cbx_idtaikhoan.DataSource = XuLyDuLieu.docDuLieuStored("docTatCaTaiKhoan", new object[] { }, new string[] { });
            dataGridView1.DataSource = XuLyDuLieu.docDulieu("select * from KhuyenMai").Tables[0];
        }
        private void QuanLyKhuyenMai_Load(object sender, EventArgs e)
        {
            refresh();
            docKM();
        }

        private void btn_themmoi_Click(object sender, EventArgs e)
        {
            object[] duLieu = new object[]
            {
                cbx_idtaikhoan.SelectedValue
                , txt_tenkm.Text
                , dtp_batdau.Value
                , dtp_ketthuc.Value
                , cb_trangthai.Checked
                , txt_tyle.Text
            };
            string[] thamSo = new string[]
            {
                 "@IDTaiKhoan"
                , "@TenKM"
                , "@BatDau"
                , "@KetThuc"
                , "@TrangThai"
                , "@TiLeKM"
            };
            if (XuLyDuLieu.capNhatDuLieuStored("ThemKM", duLieu, thamSo) == 1)
            {
                MessageBox.Show("Thêm mới thành công!");
                docKM();
                refresh();
            }
            else
            {
                MessageBox.Show("Thêm mới thất bại!");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string query = "delete KhuyenMai where IDKhuyenMai = " + txt_tenkm.Tag;
            if (XuLyDuLieu.CapNhatDuLieu(query) == 1)
            {
                MessageBox.Show("Xóa thành công!");
                docKM();
                refresh();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string query = "update KhuyenMai set "
                + " IDTaiKhoan='" + cbx_idtaikhoan.SelectedValue + "', "
                + " TenKM=N'" + txt_tenkm.Text + "', "
                + " BatDau='" + dtp_batdau.Value + "', "
                + " KetThuc='" + dtp_ketthuc.Value + "', "
                + " TrangThai='" + cb_trangthai.Checked + "' ,"
                + " TiLeKM='" + txt_tyle.Text + "' ,"
                + " where IDKhuyenMai = " + txt_tenkm.Tag;
            if (XuLyDuLieu.CapNhatDuLieu(query) == 1)
            {
                MessageBox.Show("Chỉnh sữa thành công");
                docKM();
                refresh();
            }
            else
            {
                MessageBox.Show("Chỉnh sữa thất bại");
            }
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                //Lưu tạm ID vào để hiệu chỉnh hoặc xóa
                //Lưu tạm ID vào để hiệu chỉnh hoặc xóa
                txt_tenkm.Tag = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                cbx_idtaikhoan.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txt_tenkm.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                dtp_batdau.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                dtp_ketthuc.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                cb_trangthai.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txt_tyle.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            btn_themmoi.Enabled = false;
        }
    }
}
