using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderMillTeaProgram
{
    public partial class SignForm : Form
    {
        public SignForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnshowhidepass_Click(object sender, EventArgs e)
        {

        }

        private void btnhidepass_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.PasswordChar == '*')
            {
                btnshowpass.BringToFront();
                txtMatKhau.PasswordChar = '\0';
            }
        }

        private void btnshowpass_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.PasswordChar == '\0')
            {
                btnhidepass.BringToFront();
                txtMatKhau.PasswordChar = '*';
            }
        }

        private void btnhidepass2_Click(object sender, EventArgs e)
        {
            if (txtCheckPass.PasswordChar == '\0')
            {
                btnshowpass2.BringToFront();
                txtCheckPass.PasswordChar = '*';
            }
        }

        private void btnshowpass2_Click(object sender, EventArgs e)
        {
           
            if (txtCheckPass.PasswordChar == '*')
            {
                btnhidepass2.BringToFront();
                txtCheckPass.PasswordChar = '\0';
            }
        }

        private void lblDangNhap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm Login = new LoginForm();
            Login.Show();
            this.Hide();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            string email = "user@example.com";
            bool isEmailValid = Regex.IsMatch(email, @"\w+@\w+\.\w+");
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
