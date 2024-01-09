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
    public partial class TimKiemSanPhamTheoTen : UserControl
    {
        public delegate void ThemVaoGioHang(Order oder);
        public ThemVaoGioHang themVaoGioHang;

        private ProductDAO db = new ProductDAO();
        private User user { set; get; }

        private string productName;
        public TimKiemSanPhamTheoTen()
        {
            InitializeComponent();
        }

        public TimKiemSanPhamTheoTen(string productname, User user)
        {
            InitializeComponent();
            this.productName = productname;
            this.user = user;
            this.user.listOrder = new List<Order>();
            pnlThemGioHang.Visible = false;
        }

        private void TimKiemSanPhamTheoTen_Load(object sender, EventArgs e)
        {
            dgvTimKiemSanPham.DataSource = db.timKiemSanPhamTheoTen(this.productName.Trim()).Tables[0];
        }

        private void dgvTimKiemSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvTimKiemSanPham.CurrentCell.RowIndex;
            Product product = db.getProduct((int)dgvTimKiemSanPham.Rows[r].Cells[0].Value);

            lblProductID.Text = product.id.ToString();
            lblProductName.Text = product.name;
            lblProductPrice.Text = product.price.ToString();
            lblTotalPrice.Text = (product.price * (float)numericUpDown1.Value) + "VND";
            numericUpDown1.Maximum = product.quantity;
            numericUpDown1.Value = 1;

            lblMax.Text = "(Còn lại: " + product.quantity + ")";

            pnlThemGioHang.Visible = true;
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            int quantity = (int)numericUpDown1.Value;
            int productID = int.Parse(lblProductID.Text);
            Order order = new Order();
            order.quantity = quantity;
            order.productID = productID;
            order.username = user.username;
            order.productName = lblProductName.Text;
            order.price = double.Parse(lblProductPrice.Text) * (double)numericUpDown1.Value;

            if (themVaoGioHang != null)
            {
                themVaoGioHang(order);
                MessageBox.Show("Đã thêm vào giỏ hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            pnlThemGioHang.Visible = false;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            lblTotalPrice.Text = (double.Parse(lblProductPrice.Text) * (double)numericUpDown1.Value).ToString() + "VND";
        }
    }
}
