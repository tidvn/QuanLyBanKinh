using QuanLyBanKinh.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanKinh.FORM
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            tbUser.Text = "user1";
            tbPass.Text = "1";


            if (Login(tbUser.Text, tbPass.Text))
            {
                fMain f = new fMain();
                this.Hide();
                f.ShowDialog();
                Application.Exit();
                loginSt.Text = "";
                //Console.WriteLine(nameof(loginSt.Text));
            }
            else
            {
                loginSt.Text = "Sai Tài Khoản Hoặc Mật Khẩu";
            }
        }
        public bool Login(string userName, string passWord)
        {
            return UserDAO.Instance.Login(userName, passWord);


        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
