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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_log_Click(object sender, EventArgs e)
        {
            string[] thamso = new string[] { "@Username", "@Pass" };
            object[] giatri = new object[] { txt_user.Text, txt_pass.Text };
            DataTable dt = XuLyDuLieu.docDuLieuStored("DangNhap", giatri, thamso);
            if (dt.Rows.Count == 1)
            {
                thongtindangnhap.HoTenTK = dt.Rows[0]["HoTenTK"].ToString();
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
