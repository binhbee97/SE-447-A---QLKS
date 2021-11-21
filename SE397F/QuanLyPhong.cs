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
    public partial class QuanLyPhong : Form
    {
        
        public QuanLyPhong()
        {
            InitializeComponent();
        }   
        private void QuanLyPhong_Load(object sender, EventArgs e)
        {
           
            /*btn.Name = "btntable";
            btn.Click += new System.EventHandler(this.btntable_Click);*/

            string query = "select * from Phong inner join LoaiPhong on Phong.IDLoaiPhong = LoaiPhong.IDLoaiPhong  where DuocDung=1";
            DataTable dt = XuLyDuLieu.docDulieu(query).Tables[0];
            String tabID = "";
            int dong = 0;
            int cot = 0;
            TabPage tp = null;
    
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (tabID != dt.Rows[i]["IDLoaiPhong"] + "")
                {
                    dong = 0;
                    cot = 0;
                    tabID = dt.Rows[i]["IDLoaiPhong"] + "";
                    tp = new TabPage("Loại Phòng: " + dt.Rows[i]["TenLoaiPhong"] + "");
                    tabControl1.TabPages.Add(tp);
                }
                Button bt = new Button();
              
                bt.Size = new Size(105,105);
                bt.Location = new Point(20 + cot * 200, 20 + 200 * dong);               
                if (dt.Rows[i]["TrangThai"] + "" == "False")
                {
                   
                    bt.Text = dt.Rows[i]["TenPhong"] + " (Trống)";
                    ThongTinPhong.TenPhong = bt.Text = "Phòng " + dt.Rows[i]["TenPhong"] + "";
                    bt.TextAlign = ContentAlignment.BottomCenter;
                    bt.Click += new System.EventHandler(this.btnButton_DatPhong_Click);
                   
                    bt.BackgroundImage = SE397F.Properties.Resources.room_chuadat;
                    bt.BackgroundImageLayout = ImageLayout.None;
                }
                    
                else if (dt.Rows[i]["TrangThai"] + "" == "True")
                {                   
                    bt.Text = dt.Rows[i]["TenPhong"] + " (Đã đặt)";
                    ThongTinPhong.TenPhong = bt.Text = "Phòng " + dt.Rows[i]["TenPhong"] + "";
                    bt.TextAlign = ContentAlignment.BottomCenter;
                    bt.Click += new System.EventHandler(this.btnButton_ThanhToan_Click);                                     
                    bt.BackgroundImage = SE397F.Properties.Resources.room_dadat;
                    bt.BackgroundImageLayout = ImageLayout.None;
                }
                tp.Controls.Add(bt);
                cot++;  
                if (cot == 5)
                {
                    dong++;
                    cot = 0;
                }
            }
        }
        void btnButton_DatPhong_Click(object sender, EventArgs e)
        {
            QLKhachHang qlkh = new QLKhachHang();
            this.Hide();           
            qlkh.ShowDialog();
            this.Close();
            
        }
        void btnButton_ThanhToan_Click(object sender, EventArgs e)
        {
            QLDonDatPhong qlddp= new QLDonDatPhong();
            this.Hide();
            qlddp.ShowDialog();
            this.Close();
        }
    }
}
