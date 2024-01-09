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
using DBProvider;
using Business;

namespace ProjectBakery.GUI_Layer
{
    public partial class LoginForm : Form
    {
        private UserDAO db = new UserDAO();
        private DataSet ds = new DataSet();

        public User user { set; get; }
        public bool IsLogin { set; get; }
        public bool IsRegister { set; get; }

        public LoginForm()
        {
            InitializeComponent();
            IsLogin = false;
            user = new User();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataSet ds = db.checkLogin(txtUsername.Text, txtPassword.Text);
            int status = Convert.ToInt32(ds.Tables[0].Rows[0]["status"]);

            if(status == 1)
            {
                IsLogin = true;
                user = db.getInfoUser(txtUsername.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IsRegister = true;
            this.Close();
        }

    }
}
