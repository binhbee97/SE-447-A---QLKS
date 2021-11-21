using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE397F
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //           Application.Run(new QLSach());
            Login lg = new Login();
            if (lg.ShowDialog() == DialogResult.OK) //đăng nhập thành công
                Application.Run(new Home());
            else
                Application.Exit();
        }
    }
}
