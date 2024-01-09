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
    public partial class MainForm : Form
    {
        private Label lblNamePage;

        private Panel pnlSubMenuDanhMuc { set; get; }
        private Panel pnlSubMenuThongTin { set; get; }

        private User user { set; get; }
        public bool IsLogout { set; get; }
        public MainForm()
        {
            InitializeComponent();
            IsLogout = false;
        }
        public MainForm(User user)
        {
            InitializeComponent();
            this.user = user;
            IsLogout = false;
            customizeDesing();
        }
        private void customizeDesing()
        {
            
            pnlSubMenuThongTin.Visible = false;
            pnlSubMenuDanhMuc.Visible = false;
        }
        private void hideSubMenu()
        {
            if (pnlSubMenuThongTin.Visible == true)
                pnlSubMenuThongTin.Visible = false;
            if (pnlSubMenuDanhMuc.Visible == true)
                pnlSubMenuDanhMuc.Visible = false;
        }
        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void openChildForm(UserControl childForm)
        {
            if(!pnlView.Controls.Contains(childForm))
            {
                pnlView.Controls.Add(childForm);
                childForm.Dock = DockStyle.Fill;
                childForm.BringToFront();
            }
            else
            {
                childForm.BringToFront();
            }
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            openChildForm(new MainFormViewCNPM());
            if (user.role != "Admin")
                btnNhanVien.Enabled = false;
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlSubMenuThongTin);
        }

        private void btnChinhSuaThongTin_Click(object sender, EventArgs e)
        {
            lblNamePage.Text = "Thông tin cá nhân";
            openChildForm(new ThongTinTaiKhoan(this.user));
            hideSubMenu();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            lblNamePage.Text = "Đổi mật khẩu";
            openChildForm(new changePasswordView(this.user));
            hideSubMenu();
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlSubMenuDanhMuc);
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            lblNamePage.Text = "Danh mục sản phẩm";
            openChildForm(new DSSanPham());
            hideSubMenu();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            lblNamePage.Text = "Danh mục khách hàng";
            openChildForm(new DSKhachHang());
            hideSubMenu();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            lblNamePage.Text = "Danh mục nhân viên";
            openChildForm(new DSNhanVien());
            hideSubMenu();
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            lblNamePage.Text = "Doanh thu";
            openChildForm(new ThongKeBaoCao());
            hideSubMenu();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            IsLogout = true;
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            lblNamePage.Text = "Home";
            openChildForm(new MainFormViewCNPM());
        }
    }
}
