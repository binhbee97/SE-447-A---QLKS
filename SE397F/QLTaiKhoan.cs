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
    public partial class QLTaiKhoan : Form
    {
        public QLTaiKhoan()
        {
            InitializeComponent();
        }
        void reset()
        {
            txtUsername.ResetText();
            txtPass.ResetText();
            txtHoTen.ResetText();
            txtDiaChi.ResetText();
            txtEmail.ResetText();
            txtSDT.ResetText();
        }
        void docAllTK()
        {
            dataGridView1.DataSource = XuLyDuLieu.docDulieu("select * from TaiKhoan").Tables[0];
        }

        private void QLTaiKhoan_Load(object sender, EventArgs e)
        {
            docAllTK();
        }

        private void btn_themmoi_Click(object sender, EventArgs e)
        {
            object[] duLieu = new object[]
          {
                txtUsername.Text
                , txtPass.Text
                , txtHoTen.Text
                , cbTrangThai.Checked
                , cbLoaiTK.Checked
                , txtEmail.Text
                , txtDiaChi.Text
                , txtSDT.Text
          };
            string[] thamSo = new string[]
            {
                 "@Username"
                , "@Pass"
                , "@HoTenTK"
                , "@TrangThai"
                , "@LoaiTK"
                , "@email"
                , "@DiaChi"
                , "@SDT"
            };
            if (XuLyDuLieu.capNhatDuLieuStored("ThemTK", duLieu, thamSo) == 1)
            {
                MessageBox.Show("Thêm mới thành công!");
                docAllTK();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string query = "delete TaiKhoan where IDTaiKhoan = " + txtUsername.Tag;
            if (XuLyDuLieu.CapNhatDuLieu(query) == 1)
            {
                MessageBox.Show("Xóa thành công!");
                docAllTK();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int selectedRow = e.RowIndex;
                //Lưu tạm ID vào để hiệu chỉnh hoặc xóa
                txtUsername.Tag = dataGridView1.Rows[selectedRow].Cells["IDTaiKhoan"].Value.ToString();
                txtUsername.Text = dataGridView1.Rows[selectedRow].Cells["Username"].Value.ToString();
                txtPass.Text = dataGridView1.Rows[selectedRow].Cells["Pass"].Value.ToString();
                txtHoTen.Text = dataGridView1.Rows[selectedRow].Cells["Pass"].Value.ToString();
                txtEmail.Text = dataGridView1.Rows[selectedRow].Cells["email"].Value.ToString();
                txtDiaChi.Text = dataGridView1.Rows[selectedRow].Cells["DiaChi"].Value.ToString();
                txtSDT.Text = dataGridView1.Rows[selectedRow].Cells["SDT"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string query = "update TaiKhoan set "
                + " Username='" + txtUsername.Text + "', "
                + " Pass='" + txtPass.Text + "', "
                + " HoTenTK=N'" + txtHoTen.Text + "', "
                + " TrangThai='" + cbTrangThai.Checked + "', "
                + " LoaiTK='" + cbLoaiTK.Checked + "' ,"
                + " email=N'" + txtEmail.Text + "' ,"
                + " DiaChi='" + txtDiaChi.Text + "' ,"
                + " SDT='" + txtSDT.Text + "' ,"
                + " where IDDichVu = " + txtUsername.Tag;
            if (XuLyDuLieu.CapNhatDuLieu(query) == 1)
            {
                MessageBox.Show("Chỉnh sữa thành công");
                docAllTK();
                reset();
            }
            else
            {
                MessageBox.Show("Chỉnh sữa thất bại");
            }
        }
    }
}
