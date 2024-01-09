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
    public partial class ThongKeBaoCao : UserControl
    {
        public ThongKeDAO thongkeDAO = new ThongKeDAO();
        public OrderDAO orderDAO = new OrderDAO();
        public ThongKeBaoCao()
        {
            InitializeComponent();
        }

        private void ThongKeBaoCao_Load(object sender, EventArgs e)
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
                dgvDSTransaction.DataSource = thongkeDAO.getAllBaoCaoDoanhThu().Tables[0];
            }
            else
            {
                dgvDSTransaction.DataSource = thongkeDAO.getBaoCaoDoanhThuDate(dateFrom.Text, dateTo.Text).Tables[0];
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
            string username = dgvDSTransaction.Rows[r].Cells["username"].Value.ToString();
            dgvOrderDetail.DataSource = orderDAO.getOrderDetail(username, transactionID).Tables[0];
        }
    }
}
