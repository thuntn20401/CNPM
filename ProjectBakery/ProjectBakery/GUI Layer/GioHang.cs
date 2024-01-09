using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Beans;
using Business;

namespace ProjectBakery.GUI_Layer
{
    public partial class GioHang : UserControl
    {
        public TransactionDAO transactionDB = new TransactionDAO();
        public OrderDAO orderDB = new OrderDAO();
        public User user { set; get; }
        public GioHang()
        {
            InitializeComponent();
        }
        public GioHang(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        public void LoadData()
        {
            dgvGioHang.DataSource = user.orderTable;
            lblName.Text = user.firstName + "" + user.lastName;
            lblSDT.Text = user.phone;
            lblDiaChi.Text = user.address;
            lblEmail.Text = user.email;
            lblTongTien.Text = 0 + "VND";
            btnThanhToan.Enabled = false;
        }

        private void GioHang_Load(object sender, EventArgs e)
        {
            LoadData();
            ccbPhuongThucThanhToan.SelectedIndex = 0;
        }
        private void DeleteRow(int r)
        {
            int productID = Convert.ToInt32(dgvGioHang.Rows[r].Cells["MaSP"].Value);
            for (int i = 0; i < user.orderTable.Rows.Count; i++)
            {
                if (Convert.ToInt32(user.orderTable.Rows[i]["MaSP"]) == productID)
                {
                    user.orderTable.Rows[i].Delete();
                }
            }
        }

        private void checkDonHangRong(bool check)
        {
            if (check)
            {
                btnThanhToan.Enabled = true;
                lblLuuY.Visible = false;

            }
            else
            {
                btnThanhToan.Enabled = false;
                lblLuuY.Visible = true;
            }
        }

        private void dgvGioHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvGioHang.CommitEdit(DataGridViewDataErrorContexts.Commit);
            string command = dgvGioHang.Columns[e.ColumnIndex].Name;
            if (command == "Delete")
            {
                int r = dgvGioHang.CurrentCell.RowIndex;
                DeleteRow(r);
            }
        }

        private void dgvGioHang_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            double totalPrice = 0;
            bool check = false;
            for (int i = 0; i < dgvGioHang.Rows.Count; i++)
            {
                DataGridViewRow row = dgvGioHang.Rows[i];
                if (Convert.ToBoolean(row.Cells["Selected"].Value) == true)
                {
                    check = true;
                    totalPrice += Convert.ToDouble(row.Cells["Gia"].Value);
                }
            }
            lblTongTien.Text = totalPrice.ToString() + "VND";
            checkDonHangRong(check);
            Console.WriteLine(totalPrice);
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            string err = "";
            DateTime dateNow = DateTime.Now;

            try
            {
                transactionDB.insertTransaction(ref err, user.username, user.address, user.phone, dateNow, txtNote.Text);
                int transactionID = transactionDB.getTransactionID();
                Console.WriteLine(transactionID);
                for (int i = dgvGioHang.Rows.Count - 1; i >= 0; i--)
                {
                    DataGridViewRow row = dgvGioHang.Rows[i];
                    if (Convert.ToBoolean(row.Cells["Selected"].Value) == true)
                    {
                        Order order = new Order();
                        order.username = user.username;
                        order.transactionID = transactionID;
                        order.productID = Convert.ToInt32(row.Cells["MaSP"].Value);
                        order.quantity = Convert.ToInt32(row.Cells["SoLuong"].Value);
                        orderDB.insertOrder(ref err, order);
                        DeleteRow(i);

                    }
                }
                MessageBox.Show("Đặt hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException)
            {
                MessageBox.Show("Xảy ra lỗi trong khi đặt hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ccbPhuongThucThanhToan_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ccbPhuongThucThanhToan.SelectedIndex;
            if (index == 1)
            {
                pnlATM.Visible = true;
            }
            else
            {
                pnlATM.Visible = false;
            }
        }

        private void lblTongTien_Click(object sender, EventArgs e)
        {

        }
    }
}
