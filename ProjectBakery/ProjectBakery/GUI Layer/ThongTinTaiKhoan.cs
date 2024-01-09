using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using Beans;


namespace ProjectBakery.GUI_Layer
{
    public partial class ThongTinTaiKhoan : UserControl
    {
        private UserDAO db = new UserDAO();

        private User user { set; get; }

        private ErrorProvider errorProvider { set; get; }

        public ThongTinTaiKhoan()
        {
            InitializeComponent();
        }
        public ThongTinTaiKhoan(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void loadTaiKhoanForm(User user)
        {
            user = db.getInfoUser(user.username);
            txtFirstname.Text = user.firstName;
            txtLastname.Text = user.lastName;
            txtAddress.Text = user.address;
            dtBirthday.Text = user.birthday.ToString();
            txtPhone.Text = user.phone;
            txtEmail.Text = user.email;
            lblRole.Text = user.role;
            if (user.gender == "M")
            {
                rdMale.Checked = true;
                rdFemale.Checked = false;
            }
            else
            {
                rdMale.Checked = false;
                rdFemale.Checked = true;
            }

        }

        private void ThongTinTaiKhoan_Load(object sender, EventArgs e)
        {
            loadTaiKhoanForm(this.user);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            loadTaiKhoanForm(this.user);
        }

        private void btnCapNhatThongTin_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                string gender = "";
                string err = "";
                if (rdMale.Checked == true)
                    gender = "M";
                else if (rdFemale.Checked == true)
                    gender = "F";

                if (!db.updateUser(ref err, this.user.username, this.user.password, txtFirstname.Text, txtLastname.Text, txtAddress.Text, dtBirthday.Value, gender, txtPhone.Text, txtEmail.Text, lblRole.Text))
                    MessageBox.Show("Xảy ra lỗi khi cập nhật thông tin!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    this.user = db.getInfoUser(this.user.username);
                    MessageBox.Show("Đã cập nhật thông tin cá nhân", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadTaiKhoanForm(this.user);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        bool IsValid()
        {
            bool check = true;
            if (String.IsNullOrEmpty(txtFirstname.Text))
            {
                check = false;
                errorProvider.SetError(txtFirstname, "Required");
            }
            else
            {
                errorProvider.SetError(txtFirstname, "");
            }

            if (String.IsNullOrEmpty(txtLastname.Text))
            {
                check = false;
                errorProvider.SetError(txtLastname, "Required");
            }
            else
            {
                errorProvider.SetError(txtLastname, "");
            }


            if (String.IsNullOrEmpty(txtAddress.Text))
            {
                check = false;
                errorProvider.SetError(txtAddress, "Required");
            }
            else
            {
                errorProvider.SetError(txtAddress, "");
            }

            if (String.IsNullOrEmpty(txtEmail.Text))
            {
                check = false;
                errorProvider.SetError(txtEmail, "Required");
            }
            else
            {
                errorProvider.SetError(txtEmail, "");
            }

            if (String.IsNullOrEmpty(txtPhone.Text))
            {
                check = false;
                errorProvider.SetError(txtPhone, "Required");
            }
            else
            {
                errorProvider.SetError(txtPhone, "");
            }

            return check;
        }
    }
}
