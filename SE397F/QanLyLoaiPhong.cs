using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE397F
{
    public partial class QanLyLoaiPhong : Form
    {
        public QanLyLoaiPhong()
        {
            InitializeComponent();
        }
        private void refresh()
        {
            txt_tenloaiphong.ResetText();
            txt_dongia.ResetText();
            txt_soluong.ResetText();
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            btn_themmoi.Enabled = true;
        }
        private void docLoaiPhong()
        {
            dataGridView1.DataSource = XuLyDuLieu.docDulieu("select * from LoaiPhong").Tables[0];
        }
        private void QanLyLoaiPhong_Load(object sender, EventArgs e)
        {
            cbx_idtaikhoan.DataSource = XuLyDuLieu.docDuLieuStored("docTatCaTaiKhoan", new object[] { }, new string[] { });
            docLoaiPhong();
        }

        private void chọnẢnhMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";// lọc chỉ còn lại file ảnh
            if (f.ShowDialog() == DialogResult.OK)
                pictureBox1.Image = Image.FromFile(f.FileName);
        }

        private void xóaẢnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = SE397F.Properties.Resources.NoImage;
        }

        private void btn_themmoi_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
            byte[] photo_aray = new byte[ms.Length];
            ms.Position = 0;
            ms.Read(photo_aray, 0, photo_aray.Length);

            object[] duLieu = new object[]
            {
                cbx_idtaikhoan.SelectedValue
                , txt_tenloaiphong.Text
                , txt_dongia.Text
                , photo_aray
                , txt_soluong.Text
            };
            string[] thamSo = new string[]
            {
                 "@IDTaiKhoan"
                , "@TenLoaiPhong"
                , "@DonGiaLoaiPhong"
                , "@HinhAnh"
                , "@SoLuong"
            };
            if (XuLyDuLieu.capNhatDuLieuStored("ThemLoaiPhong", duLieu, thamSo) == 1)
            {
                MessageBox.Show("Thêm mới thành công!");
                docLoaiPhong();
            }
            else
            {
                MessageBox.Show("Thêm mới thất bại!");
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                //Lưu tạm ID vào để hiệu chỉnh hoặc xóa
                txt_tenloaiphong.Tag = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                cbx_idtaikhoan.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txt_tenloaiphong.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txt_dongia.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                byte[] image = (byte[])dataGridView1.CurrentRow.Cells[4].Value;
                if (image != null)
                {
                    MemoryStream ms = new MemoryStream(image);
                    pictureBox1.Image = Image.FromStream(ms);
                }
                else
                {
                    pictureBox1.Image = SE397F.Properties.Resources.NoImage;
                    MemoryStream ms = new MemoryStream(image);
                    pictureBox1.Image = Image.FromStream(ms);
                    
                }
                txt_soluong.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            btn_themmoi.Enabled = false;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string query = "delete LoaiPhong where IDLoaiPhong = " + txt_tenloaiphong.Tag;
            if (XuLyDuLieu.CapNhatDuLieu(query) == 1)
            {
                MessageBox.Show("Xóa loại phòng thành công!");
                docLoaiPhong();
                refresh();
            }
            else
            {
                MessageBox.Show("Xóa loại phòng thất bại!");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            /*MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            byte[] img = ms.ToArray();*/
            MemoryStream ms = new MemoryStream();
            try
            {
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] img = ms.ToArray();
               /* dataGridView1.CurrentRow.Cells[4].Value = img;*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }               
            string query = "update LoaiPhong set "
                + " IDTaiKhoan='" + cbx_idtaikhoan.SelectedValue + "', "
                + " TenLoaiPhong=N'" + txt_tenloaiphong.Text + "', "
                + " DonGiaLoaiPhong='" + txt_dongia.Text + "' ,"
           /*     + " HinhAnh ='" + img + "' ,"*/
                + " SoLuong ='" + txt_soluong.Text + "' "
                + " where IDLoaiPhong = " + txt_tenloaiphong.Tag;
            if (XuLyDuLieu.CapNhatDuLieu(query) == 1)
            {
                MessageBox.Show("Chỉnh sữa thành công");
                docLoaiPhong();
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
            pictureBox1.Image = SE397F.Properties.Resources.NoImage;
        }

        
    }
}
