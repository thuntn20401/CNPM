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
    public partial class changePasswordView : UserControl
    {
        UserDAO db = new UserDAO();
        private User user { set; get; }
        private ErrorProvider errorProvider { set; get; }
        public changePasswordView()
        {
            InitializeComponent();
        }
        public changePasswordView(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if(IsValid())
            {
                string err = "";
                DataSet ds = db.changePassword(ref err, this.user.username, txtOldPassword.Text, txtNewPassword.Text, txtConfirmPassword.Text);
                string status = ds.Tables[0].Rows[0]["status"].ToString();
                MessageBox.Show(status, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo");
            }
        }
        bool IsValid()
        {
            bool check = true;
            if(String.IsNullOrEmpty(txtOldPassword.Text))
            {
                check = false;
                errorProvider.SetError(txtOldPassword, "Required");
            }
            else
            {
                errorProvider.SetError(txtOldPassword, "");
            }
            if (String.IsNullOrEmpty(txtNewPassword.Text))
            {
                check = false;
                errorProvider.SetError(txtNewPassword, "Required");
            }
            else
            {
                errorProvider.SetError(txtNewPassword, "");
            }
            if (String.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                check = false;
                errorProvider.SetError(txtConfirmPassword, "Required");
            }
            else
            {
                errorProvider.SetError(txtConfirmPassword, "");
            }

            return check;
        }
    }
}
