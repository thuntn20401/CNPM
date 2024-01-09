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
    public partial class QuanLyDonHangCaNhan : UserControl
    {
        public User user { set; get; }
        public TransactionDAO transactionDAO = new TransactionDAO();
        public OrderDAO orderDAO = new OrderDAO();
        public QuanLyDonHangCaNhan()
        {
            InitializeComponent();
        }
        public QuanLyDonHangCaNhan(User user)
        {
            this.user = user;
            InitializeComponent();
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void QuanLyDonHangCaNhan_Load(object sender, EventArgs e)
        {
            rdAll.Checked = true;
            rdDate.Checked = false;
            btnOK_Click(sender, e);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            bool check = rdAll.Checked;
            double tong = 0;
            if (check == true)
            {
                dgvDSTransaction.DataSource = transactionDAO.getTransactionByUser(user.username).Tables[0];
            }
            else
            {
                dgvDSTransaction.DataSource = transactionDAO.getTransactionByUserForDate(user.username, dateFrom.Text, dateTo.Text).Tables[0];
            }
            lblTongDon.Text = dgvDSTransaction.Rows.Count.ToString();
            foreach (DataGridViewRow row in dgvDSTransaction.Rows)
            {
                tong += Convert.ToDouble(row.Cells["TotalPrice"].Value);
            }
            lblTongTien.Text = tong + "VND";
        }

        private void dgvDSTransaction_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvDSTransaction.CurrentCell.RowIndex;
            int transactionID = Convert.ToInt32(dgvDSTransaction.Rows[r].Cells["ID"].Value);
            dgvOrderDetail.DataSource = orderDAO.getOrderDetail(user.username, transactionID).Tables[0];
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string err = "";
            try
            {
                int r = dgvDSTransaction.CurrentCell.RowIndex;
                int transactionID = Convert.ToInt32(dgvDSTransaction.Rows[r].Cells["ID"].Value);
                transactionDAO.deleteTransaction(ref err, transactionID);
                btnOK_Click(sender, e);

                MessageBox.Show("Xoá đơn hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException)
            {
                MessageBox.Show("Xảy ra lỗi! Không thể xoá đơn hàng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
