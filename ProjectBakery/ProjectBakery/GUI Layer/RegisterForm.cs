using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Beans;
using Business;

namespace ProjectBakery.GUI_Layer
{
    public partial class RegisterForm : Form
    {
        public UserDAO userDAO = new UserDAO();
        public bool IsLogin { set; get; }
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string confirmpw = txtConfirmPassword.Text;
            string err = "";

            if(username != null && username != "" && password != null & password != "" && password == confirmpw)
            {
                if(!userDAO.Register(ref err, username, password, confirmpw))
                {
                    MessageBox.Show("Username was exist!", "About", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Register success!", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Please enter all correct information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IsLogin = true;
            this.Close();
        }
    }
}
