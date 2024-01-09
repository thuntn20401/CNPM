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
using System.Text.RegularExpressions;

namespace ProjectBakery.GUI_Layer
{
    public partial class DSSanPham : UserControl
    {
        ProductDAO dbProduct = new ProductDAO();
        CategoriesDAO dbCategories = new CategoriesDAO();
        SupplierDAO dbSupplier = new SupplierDAO();

        private ErrorProvider errorProvider { set; get; }
        public DSSanPham()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            dgvProduct.DataSource = dbProduct.getAllProduct().Tables[0];
            cbbCatename.DataSource = dbCategories.getAllNameCategories().Tables[0];
            cbbCatename.DisplayMember = "cate_name";
            cbbCatename.ValueMember = "id";
            cbbNPP.DataSource = dbSupplier.getAllNameSupplier().Tables[0];
            cbbNPP.DisplayMember = "sup_name";
            cbbNPP.ValueMember = "id";
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void DSSanPham_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvProduct.CurrentCell.RowIndex;
            txtTenSanPham.Text = dgvProduct.Rows[r].Cells[1].Value.ToString();
            txtGiaBan.Text = dgvProduct.Rows[r].Cells[6].Value.ToString();
            txtGiaGoc.Text = dgvProduct.Rows[r].Cells[5].Value.ToString();
            txtSoLuong.Text = dgvProduct.Rows[r].Cells[4].Value.ToString();
            txtMoTa.Text = dgvProduct.Rows[r].Cells[9].Value.ToString();
            dtNSX.Text = dgvProduct.Rows[r].Cells[7].Value.ToString();
            dtHSD.Text = dgvProduct.Rows[r].Cells[8].Value.ToString();
            cbbCatename.SelectedIndex = dbCategories.getCategoriesID(dgvProduct.Rows[r].Cells[2].Value.ToString()) - 1;
            cbbNPP.SelectedIndex = dbSupplier.getSupplierID(dgvProduct.Rows[r].Cells[3].Value.ToString()) - 1;
            Console.WriteLine(cbbCatename.SelectedValue + " " + cbbNPP.SelectedValue);
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            string err = "";
            if (IsValid())
            {
                if (!dbProduct.insertProduct(ref err, Convert.ToInt32(cbbNPP.SelectedValue), Convert.ToInt32(cbbCatename.SelectedValue), txtTenSanPham.Text, Convert.ToInt32(txtSoLuong.Text), Convert.ToDouble(txtGiaGoc.Text),
                                Convert.ToDouble(txtGiaBan.Text), txtMoTa.Text, dtNSX.Value, dtHSD.Value))
                    MessageBox.Show("Xảy ra lỗi khi thêm sản phẩm!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show("Thêm sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điên đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCapNhatSP_Click(object sender, EventArgs e)
        {
            string err = "";
            if (IsValid())
            {
                int r = dgvProduct.CurrentCell.RowIndex;
                if (!dbProduct.updateProduct(ref err, Convert.ToInt32(dgvProduct.Rows[r].Cells["pro_id"].Value), Convert.ToInt32(cbbNPP.SelectedValue), Convert.ToInt32(cbbCatename.SelectedValue), txtTenSanPham.Text, Convert.ToInt32(txtSoLuong.Text), Convert.ToDouble(txtGiaGoc.Text),
                                    Convert.ToDouble(txtGiaBan.Text), txtMoTa.Text, dtNSX.Value, dtHSD.Value))
                    MessageBox.Show("Xảy ra lỗi khi cập nhật sản phẩm!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            string err = "";
            try
            {
                int r = dgvProduct.CurrentCell.RowIndex;
                int pro_id = Convert.ToInt32(dgvProduct.Rows[r].Cells["pro_id"].Value);
                if (!dbProduct.deleteProduct(ref err, pro_id))
                    MessageBox.Show("Lỗi! Không thể xoá sản phẩm", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show("Xoá sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Xoá sản phẩm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^\d+$");
            return regex.IsMatch(pText);
        }
        bool IsValid()
        {
            bool check = true;
            if (String.IsNullOrEmpty(txtTenSanPham.Text))
            {
                check = false;
                errorProvider.SetError(txtTenSanPham, "Required");
            }
            else
            {
                errorProvider.SetError(txtTenSanPham, "");
            }

            if (String.IsNullOrEmpty(txtMoTa.Text))
            {
                check = false;
                errorProvider.SetError(txtMoTa, "Required");
            }
            else
            {
                errorProvider.SetError(txtMoTa, "");
            }

            if (String.IsNullOrEmpty(txtGiaBan.Text) || IsNumber(txtGiaBan.Text) == false)
            {
                check = false;
                errorProvider.SetError(txtGiaBan, "Required and need a numeric");
            }
            else
            {
                errorProvider.SetError(txtGiaBan, "");
            }

            if (String.IsNullOrEmpty(txtGiaGoc.Text) || IsNumber(txtGiaGoc.Text) == false)
            {
                check = false;
                errorProvider.SetError(txtGiaGoc, "Required and need a numeric");
            }
            else
            {
                errorProvider.SetError(txtGiaGoc, "");
            }


            if (String.IsNullOrEmpty(txtSoLuong.Text))
            {
                check = false;
                errorProvider.SetError(txtSoLuong, "Required");
            }
            else
            {
                errorProvider.SetError(txtSoLuong, "");
            }

            return check;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTenSanPham.Clear();
            txtSoLuong.Clear();
            txtGiaGoc.Clear();
            txtGiaBan.Clear();
            txtMoTa.Clear();
        }
    }
}
