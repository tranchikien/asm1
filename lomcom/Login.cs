using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lomcom
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;


            // Kiểm tra tên đăng nhập và mật khẩu
            if (username == "trankien" && password == "hi12345")
            {
                // Đăng nhập thành công, mở form chính
                // Đóng Form Login
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
                
            }
            else
            {
                MessageBox.Show("Incorrect username or password");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
