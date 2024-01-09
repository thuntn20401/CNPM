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
using System.Text.RegularExpressions;

namespace ProjectBakery.GUI_Layer
{
    public partial class DSKhachHang : UserControl
    {
        private UserDAO db = new UserDAO();
        private ErrorProvider errorProvider { set; get; }
        public DSKhachHang()
        {
            InitializeComponent();
        }
        private void KhachHang_Load(object sender, EventArgs e)
        {
            load_data();
        }
        private void load_data()
        {
            dgvDSKhachHang.DataSource = db.getAllKhachHang().Tables[0];
            List<String> listRole = new List<string>()
            {
                "Customer"
            };
            cbbRole.DataSource = listRole;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                string gender;
                string err = "";
                if (rdMale.Checked == true)
                    gender = "M";
                else
                    gender = "F";

                if (!db.updateUser(ref err, txtUsername.Text, txtPassword.Text, txtFirstname.Text, txtLastname.Text, txtAddress.Text, dtpBirthday.Value, gender, txtPhone.Text, txtEmail.Text, cbbRole.SelectedValue.ToString()))
                    MessageBox.Show("Xảy ra lỗi khi cập nhật!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load_data();
                    clear_frm();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void clear_frm()
        {
            txtPassword.Enabled = true;
            cbbRole.Enabled = true;
            txtUsername.Clear();
            txtFirstname.Clear();
            txtLastname.Clear();
            txtAddress.Clear();
            rdMale.Checked = true;
            rdFemale.Checked = false;
            txtPhone.Clear();
            txtEmail.Clear();
            txtPassword.Clear();

        }

        bool IsValid()
        {
            bool check = true;
            if (String.IsNullOrEmpty(txtUsername.Text))
            {
                check = false;
                errorProvider.SetError(txtUsername, "Required");
            }
            else
            {
                errorProvider.SetError(txtUsername, "");
            }

            if (String.IsNullOrEmpty(txtPassword.Text))
            {
                check = false;
                errorProvider.SetError(txtPassword, "Required");
            }
            else
            {
                errorProvider.SetError(txtPassword, "");
            }

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

            if (String.IsNullOrEmpty(txtPhone.Text) && IsNumber(txtPhone.Text))
            {
                check = false;
                errorProvider.SetError(txtPhone, "Required and need a number phone");
            }
            else
            {
                errorProvider.SetError(txtPhone, "");
            }

            return check;
        }

        public bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0 - 9] *\.?[0 - 9] +$");
            return regex.IsMatch(pText);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                string err = "";
                string gender;
                if (rdMale.Checked == true)
                    gender = "M";
                else
                    gender = "F";

                if (!db.insertUser(ref err, txtUsername.Text, txtPassword.Text, txtFirstname.Text, txtLastname.Text, txtAddress.Text, dtpBirthday.Value, gender, txtPhone.Text, txtEmail.Text, cbbRole.SelectedValue.ToString()))
                    MessageBox.Show("Xảy ra lỗi khi thêm khách hàng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show("Đã thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load_data();
                    clear_frm();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string err = "";
                if (!db.delelteUser(ref err, txtUsername.Text))
                    MessageBox.Show("Xảy ra lỗi khi xoá khách hàng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    load_data();
                    MessageBox.Show("Đã xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Xoá khách hàng thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void load_KhachHangForm(string username)
        {
            User user = db.getInfoUser(username);

            txtUsername.Text = user.username;
            txtFirstname.Text = user.firstName;
            txtLastname.Text = user.lastName;
            txtAddress.Text = user.address;
            dtpBirthday.Text = user.birthday.ToString();
            txtPhone.Text = user.phone;
            txtEmail.Text = user.email;
            txtPassword.Text = user.password;
            cbbRole.SelectedItem = user.role;
            if (user.gender == "M")
            {
                rdMale.Checked = true;
                rdFemale.Checked = false;
            }
            else
            {
                rdFemale.Checked = false;
                rdFemale.Checked = true;
            }
        }

        private void dgvDSKhachHang_Click(object sender, EventArgs e)
        {

        }

        private void dgvDSKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvDSKhachHang.CurrentCell.RowIndex;
            load_KhachHangForm(dgvDSKhachHang.Rows[r].Cells[0].Value.ToString());
            txtPassword.Enabled = false;
            cbbRole.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear_frm();
        }
    }
}
