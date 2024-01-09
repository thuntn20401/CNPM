
namespace ProjectBakery.GUI_Layer
{
    partial class TimKiemSanPhamTheoTen
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvTimKiemSanPham = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pronameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proquantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.propriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriesID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pronsxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prohsdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bAKERYDataSet = new ProjectBakery.BAKERYDataSet();
            this.productTableAdapter = new ProjectBakery.BAKERYDataSetTableAdapters.ProductTableAdapter();
            this.pnlThemGioHang = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblMax = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnDatHang = new System.Windows.Forms.Button();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiemSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAKERYDataSet)).BeginInit();
            this.pnlThemGioHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTimKiemSanPham
            // 
            this.dgvTimKiemSanPham.AllowUserToAddRows = false;
            this.dgvTimKiemSanPham.AutoGenerateColumns = false;
            this.dgvTimKiemSanPham.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvTimKiemSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimKiemSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.pronameDataGridViewTextBoxColumn,
            this.proquantityDataGridViewTextBoxColumn,
            this.propriceDataGridViewTextBoxColumn,
            this.supplierID,
            this.categoriesID,
            this.pronsxDataGridViewTextBoxColumn,
            this.prohsdDataGridViewTextBoxColumn,
            this.pro_description});
            this.dgvTimKiemSanPham.DataSource = this.productBindingSource;
            this.dgvTimKiemSanPham.Location = new System.Drawing.Point(26, 33);
            this.dgvTimKiemSanPham.Name = "dgvTimKiemSanPham";
            this.dgvTimKiemSanPham.RowHeadersWidth = 62;
            this.dgvTimKiemSanPham.RowTemplate.Height = 28;
            this.dgvTimKiemSanPham.Size = new System.Drawing.Size(1330, 875);
            this.dgvTimKiemSanPham.TabIndex = 0;
            this.dgvTimKiemSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTimKiemSanPham_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Mã sản phẩm";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 150;
            // 
            // pronameDataGridViewTextBoxColumn
            // 
            this.pronameDataGridViewTextBoxColumn.DataPropertyName = "pro_name";
            this.pronameDataGridViewTextBoxColumn.HeaderText = "Tên sản phẩm";
            this.pronameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pronameDataGridViewTextBoxColumn.Name = "pronameDataGridViewTextBoxColumn";
            this.pronameDataGridViewTextBoxColumn.Width = 170;
            // 
            // proquantityDataGridViewTextBoxColumn
            // 
            this.proquantityDataGridViewTextBoxColumn.DataPropertyName = "pro_quantity";
            this.proquantityDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.proquantityDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.proquantityDataGridViewTextBoxColumn.Name = "proquantityDataGridViewTextBoxColumn";
            this.proquantityDataGridViewTextBoxColumn.Width = 90;
            // 
            // propriceDataGridViewTextBoxColumn
            // 
            this.propriceDataGridViewTextBoxColumn.DataPropertyName = "pro_price";
            this.propriceDataGridViewTextBoxColumn.HeaderText = "Giá tiền";
            this.propriceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.propriceDataGridViewTextBoxColumn.Name = "propriceDataGridViewTextBoxColumn";
            this.propriceDataGridViewTextBoxColumn.Width = 150;
            // 
            // supplierID
            // 
            this.supplierID.DataPropertyName = "supplierID";
            this.supplierID.HeaderText = "Mã nhà phân phối";
            this.supplierID.MinimumWidth = 8;
            this.supplierID.Name = "supplierID";
            this.supplierID.Width = 150;
            // 
            // categoriesID
            // 
            this.categoriesID.DataPropertyName = "categoriesID";
            this.categoriesID.HeaderText = "Danh mục";
            this.categoriesID.MinimumWidth = 8;
            this.categoriesID.Name = "categoriesID";
            this.categoriesID.Width = 150;
            // 
            // pronsxDataGridViewTextBoxColumn
            // 
            this.pronsxDataGridViewTextBoxColumn.DataPropertyName = "pro_nsx";
            this.pronsxDataGridViewTextBoxColumn.HeaderText = "Ngày sản xuất";
            this.pronsxDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pronsxDataGridViewTextBoxColumn.Name = "pronsxDataGridViewTextBoxColumn";
            this.pronsxDataGridViewTextBoxColumn.Width = 150;
            // 
            // prohsdDataGridViewTextBoxColumn
            // 
            this.prohsdDataGridViewTextBoxColumn.DataPropertyName = "pro_hsd";
            this.prohsdDataGridViewTextBoxColumn.HeaderText = "Hạn sử dụng";
            this.prohsdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.prohsdDataGridViewTextBoxColumn.Name = "prohsdDataGridViewTextBoxColumn";
            this.prohsdDataGridViewTextBoxColumn.Width = 150;
            // 
            // pro_description
            // 
            this.pro_description.DataPropertyName = "pro_description";
            this.pro_description.HeaderText = "Mô tả";
            this.pro_description.MinimumWidth = 8;
            this.pro_description.Name = "pro_description";
            this.pro_description.Width = 150;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.bAKERYDataSet;
            // 
            // bAKERYDataSet
            // 
            this.bAKERYDataSet.DataSetName = "BAKERYDataSet";
            this.bAKERYDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // pnlThemGioHang
            // 
            this.pnlThemGioHang.Controls.Add(this.label3);
            this.pnlThemGioHang.Controls.Add(this.numericUpDown1);
            this.pnlThemGioHang.Controls.Add(this.lblMax);
            this.pnlThemGioHang.Controls.Add(this.label8);
            this.pnlThemGioHang.Controls.Add(this.label2);
            this.pnlThemGioHang.Controls.Add(this.lblProductPrice);
            this.pnlThemGioHang.Controls.Add(this.lblProductID);
            this.pnlThemGioHang.Controls.Add(this.lblProductName);
            this.pnlThemGioHang.Controls.Add(this.label4);
            this.pnlThemGioHang.Controls.Add(this.label1);
            this.pnlThemGioHang.Controls.Add(this.label9);
            this.pnlThemGioHang.Controls.Add(this.btnHuy);
            this.pnlThemGioHang.Controls.Add(this.btnDatHang);
            this.pnlThemGioHang.Controls.Add(this.lblTotalPrice);
            this.pnlThemGioHang.Location = new System.Drawing.Point(1378, 33);
            this.pnlThemGioHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlThemGioHang.Name = "pnlThemGioHang";
            this.pnlThemGioHang.Size = new System.Drawing.Size(489, 875);
            this.pnlThemGioHang.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(358, 47);
            this.label3.TabIndex = 37;
            this.label3.Text = "Thêm Vào Giỏ Hàng";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(165, 352);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(122, 40);
            this.numericUpDown1.TabIndex = 36;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMax.Location = new System.Drawing.Point(297, 355);
            this.lblMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(63, 36);
            this.lblMax.TabIndex = 28;
            this.lblMax.Text = "null";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 355);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 36);
            this.label8.TabIndex = 29;
            this.label8.Text = "Số lượng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 265);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 36);
            this.label2.TabIndex = 30;
            this.label2.Text = "Giá:";
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductPrice.Location = new System.Drawing.Point(96, 265);
            this.lblProductPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(63, 36);
            this.lblProductPrice.TabIndex = 31;
            this.lblProductPrice.Text = "null";
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductID.Location = new System.Drawing.Point(210, 72);
            this.lblProductID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(63, 36);
            this.lblProductID.TabIndex = 32;
            this.lblProductID.Text = "null";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(210, 169);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(63, 36);
            this.lblProductName.TabIndex = 33;
            this.lblProductName.Text = "null";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 72);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 36);
            this.label4.TabIndex = 34;
            this.label4.Text = "Mã sản phẩm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 169);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 36);
            this.label1.TabIndex = 35;
            this.label1.Text = "Tên sản phẩm:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 449);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 36);
            this.label9.TabIndex = 25;
            this.label9.Text = "Tổng tiền:";
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Transparent;
            this.btnHuy.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnHuy.FlatAppearance.BorderSize = 2;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.Red;
            this.btnHuy.Location = new System.Drawing.Point(255, 549);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(219, 52);
            this.btnHuy.TabIndex = 27;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnDatHang
            // 
            this.btnDatHang.BackColor = System.Drawing.Color.Transparent;
            this.btnDatHang.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDatHang.FlatAppearance.BorderSize = 2;
            this.btnDatHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatHang.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDatHang.Location = new System.Drawing.Point(26, 549);
            this.btnDatHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDatHang.Name = "btnDatHang";
            this.btnDatHang.Size = new System.Drawing.Size(219, 52);
            this.btnDatHang.TabIndex = 27;
            this.btnDatHang.Text = "Thêm";
            this.btnDatHang.UseVisualStyleBackColor = false;
            this.btnDatHang.Click += new System.EventHandler(this.btnDatHang_Click);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(164, 449);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(63, 36);
            this.lblTotalPrice.TabIndex = 26;
            this.lblTotalPrice.Text = "null";
            // 
            // TimKiemSanPhamTheoTen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlThemGioHang);
            this.Controls.Add(this.dgvTimKiemSanPham);
            this.Name = "TimKiemSanPhamTheoTen";
            this.Size = new System.Drawing.Size(1884, 965);
            this.Load += new System.EventHandler(this.TimKiemSanPhamTheoTen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiemSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAKERYDataSet)).EndInit();
            this.pnlThemGioHang.ResumeLayout(false);
            this.pnlThemGioHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTimKiemSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pronameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proquantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn propriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierID;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriesID;
        private System.Windows.Forms.DataGridViewTextBoxColumn pronsxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prohsdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_description;
        private System.Windows.Forms.BindingSource productBindingSource;
        private BAKERYDataSet bAKERYDataSet;
        private BAKERYDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.Panel pnlThemGioHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnDatHang;
        private System.Windows.Forms.Label lblTotalPrice;
    }
}
