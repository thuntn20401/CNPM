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
    public partial class MainFormCustomer : Form
    {
        private User user { set; get; }
        public bool IsLogout { set; get; }
        private Panel pnlSubMenuThongTin { set; get; }
        private Label lblNamePage { set; get; }

        public MainFormCustomer()
        {
            InitializeComponent();
            IsLogout = false;
            customizeDesing();

        }

        public MainFormCustomer(User user)
        {
            InitializeComponent();
            customizeDesing();
            this.user = user;
            IsLogout = false;
            this.user.orderTable = new DataTable();
            user.orderTable.Columns.Add("MaSP");
            user.orderTable.Columns.Add("TenSP");
            user.orderTable.Columns.Add("SoLuong");
            user.orderTable.Columns.Add("Gia");
        }
        private void customizeDesing()
        {
            pnlSubMenuThongTin.Visible = false;
        }
        private void hideSubMenu()
        {
            if (pnlSubMenuThongTin.Visible == true)
                pnlSubMenuThongTin.Visible = false;
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
            if (!pnlView.Controls.Contains(childForm))
            {
                pnlView.Controls.Add(childForm);
                childForm.Dock = DockStyle.Fill;
                childForm.BringToFront();
            }
            else
                childForm.BringToFront();

        }

        private void MainFormCustomer_Load(object sender, EventArgs e)
        {
            pnlView.Controls.Add(new MainFormViewCNPM());
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lblNamePage.Text = "Tìm kiếm sản phẩm";
            TimKiemSanPhamTheoTen frm = new TimKiemSanPhamTheoTen(txtSearch.Text, this.user);
            frm.themVaoGioHang = new TimKiemSanPhamTheoTen.ThemVaoGioHang(LoadGioHang);
            openChildForm(frm);
        }
        private void LoadGioHang(Order order)
        {

            if (user.orderTable.Rows.Count == 0)
            {
                user.orderTable.Rows.Add(order.productID, order.productName, order.quantity, order.price);
            }
            else
            {
                int vitri = -1;
                for (int i = 0; i < user.orderTable.Rows.Count; i++)
                {
                    if (user.orderTable.Rows[i]["MaSP"].ToString() == order.productID.ToString())
                        vitri = i;
                }
                if (vitri != -1)
                {
                    int currQuantity = int.Parse(user.orderTable.Rows[vitri]["SoLuong"].ToString());
                    user.orderTable.Rows[vitri]["SoLuong"] = (currQuantity + order.quantity);

                }
                else
                {
                    user.orderTable.Rows.Add(order.productID, order.productName, order.quantity, order.price);
                }

            }
            Console.WriteLine(user.orderTable.Rows.Count);
            foreach (DataRow row in user.orderTable.Rows)
            {
                Console.WriteLine(row["TenSP"] + " " + row["SoLuong"]);
            }

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            lblNamePage.Text = "Home";
            openChildForm(new MainFormViewCNPM());
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlSubMenuThongTin);
        }

        private void btnChinhSuaThongTin_Click(object sender, EventArgs e)
        {
            lblNamePage.Text = "Thông tin cá nhân";
            openChildForm(new ThongTinTaiKhoan(user));
            hideSubMenu();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            lblNamePage.Text = "Đổi mật khẩu";
            openChildForm(new changePasswordView(user));
            hideSubMenu();
        }

        private void btnGioHang_Click(object sender, EventArgs e)
        {
            lblNamePage.Text = "Giỏ hàng";
            openChildForm(new GioHang(user));
        }

        private void btnQuanLyDonHang_Click(object sender, EventArgs e)
        {
            lblNamePage.Text = "Quản lí đơn hàng";
            openChildForm(new QuanLyDonHangCaNhan(this.user));
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            IsLogout = true;
            this.Close();
        }
    }
}
