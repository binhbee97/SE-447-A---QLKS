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
    public partial class QuanLyThietBi : Form
    {
        public QuanLyThietBi()
        {
            InitializeComponent();
        }
        private void refresh()
        {
            txt_tenthietbi.ResetText();
            txt_dongia.ResetText();
            txt_soluong.ResetText();
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            btn_themmoi.Enabled = true;
        }
        private void docTB()
        {      
            cbx_idphong.DataSource = XuLyDuLieu.docDuLieuStored("docTatCaPhong", new object[] { }, new string[] { });
            cbx_idtaikhoan.DataSource = XuLyDuLieu.docDuLieuStored("docTatCaTaiKhoan", new object[] { }, new string[] { });
            dataGridView1.DataSource = XuLyDuLieu.docDulieu("select * from ThietBi").Tables[0];
        }
        private void QuanLyThietBi_Load(object sender, EventArgs e)
        {
            docTB();
            refresh();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                //Lưu tạm ID vào để hiệu chỉnh hoặc xóa
                //Lưu tạm ID vào để hiệu chỉnh hoặc xóa
                txt_tenthietbi.Tag = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                cbx_idphong.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txt_tenthietbi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txt_dongia.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txt_soluong.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                cb_trangthai.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                rtb_ghichu.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            btn_themmoi.Enabled = false;
        }

        private void btn_themmoi_Click(object sender, EventArgs e)
        {
            object[] duLieu = new object[]
            {             
                 cbx_idphong.SelectedValue
                , txt_tenthietbi.Text
                , txt_dongia.Text
                , txt_soluong.Text
                , cb_trangthai.Checked
                , rtb_ghichu.Text
            };
            string[] thamSo = new string[]
            {
              
                 "@IDPhong"
                , "@TenTB"
                , "@DonGiaTB"
                , "@SoLuong"
                , "@TrangThai"
                , "@GhiChu"
            };
            if (XuLyDuLieu.capNhatDuLieuStored("ThemTB", duLieu, thamSo) == 1)
            {
                MessageBox.Show("Thêm mới thành công!");
                docTB();
                refresh();
            }
            else
            {
                MessageBox.Show("Thêm mới thất bại!");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string query = "delete ThietBi where IDThietBi = " + txt_tenthietbi.Tag;
            if (XuLyDuLieu.CapNhatDuLieu(query) == 1)
            {
                MessageBox.Show("Xóa thành công!");
                docTB();
                refresh();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }
        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void cbx_idphong_SelectedValueChanged(object sender, EventArgs e)
        {
            string query = "Select * from Phong where IDPhong='" + cbx_idphong.Text + "'";
            DataTable dt = XuLyDuLieu.docDulieu(query).Tables[0];
            if (dt.Rows.Count > 0)
            {
                cbx_idphong.Tag = dt.Rows[0]["IDPhong"];
                rtb_idphong.Text = "Mã phòng: " + dt.Rows[0]["MaPhong"] + "";
            }
        }
    }
}
