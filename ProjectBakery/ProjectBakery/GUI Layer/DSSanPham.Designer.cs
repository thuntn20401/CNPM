
namespace ProjectBakery.GUI_Layer
{
    partial class DSSanPham
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnXoaSP = new System.Windows.Forms.Button();
            this.btnCapNhatSP = new System.Windows.Forms.Button();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.dtHSD = new System.Windows.Forms.DateTimePicker();
            this.dtNSX = new System.Windows.Forms.DateTimePicker();
            this.cbbCatename = new System.Windows.Forms.ComboBox();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bAKERYDataSet = new ProjectBakery.BAKERYDataSet();
            this.cbbNPP = new System.Windows.Forms.ComboBox();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.txtGiaGoc = new System.Windows.Forms.TextBox();
            this.txtTenSanPham = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new ProjectBakery.BAKERYDataSetTableAdapters.ProductTableAdapter();
            this.supplierTableAdapter = new ProjectBakery.BAKERYDataSetTableAdapters.SupplierTableAdapter();
            this.categoriesTableAdapter = new ProjectBakery.BAKERYDataSetTableAdapters.CategoriesTableAdapter();
            this.pro_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriesID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proFirstPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proNSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proHSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAKERYDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnXoaSP);
            this.groupBox1.Controls.Add(this.btnCapNhatSP);
            this.groupBox1.Controls.Add(this.btnThemSP);
            this.groupBox1.Controls.Add(this.txtMoTa);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.dtHSD);
            this.groupBox1.Controls.Add(this.dtNSX);
            this.groupBox1.Controls.Add(this.cbbCatename);
            this.groupBox1.Controls.Add(this.cbbNPP);
            this.groupBox1.Controls.Add(this.txtGiaBan);
            this.groupBox1.Controls.Add(this.txtGiaGoc);
            this.groupBox1.Controls.Add(this.txtTenSanPham);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dgvProduct);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1918, 965);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnClear.FlatAppearance.BorderSize = 2;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnClear.Location = new System.Drawing.Point(1501, 259);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(276, 62);
            this.btnClear.TabIndex = 71;
            this.btnClear.Text = "Clear ";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnXoaSP
            // 
            this.btnXoaSP.BackColor = System.Drawing.Color.Transparent;
            this.btnXoaSP.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnXoaSP.FlatAppearance.BorderSize = 2;
            this.btnXoaSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaSP.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoaSP.ForeColor = System.Drawing.Color.Red;
            this.btnXoaSP.Location = new System.Drawing.Point(1501, 351);
            this.btnXoaSP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.Size = new System.Drawing.Size(276, 62);
            this.btnXoaSP.TabIndex = 70;
            this.btnXoaSP.Text = "Xóa sản phẩm";
            this.btnXoaSP.UseVisualStyleBackColor = false;
            this.btnXoaSP.Click += new System.EventHandler(this.btnXoaSP_Click);
            // 
            // btnCapNhatSP
            // 
            this.btnCapNhatSP.BackColor = System.Drawing.Color.Transparent;
            this.btnCapNhatSP.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnCapNhatSP.FlatAppearance.BorderSize = 2;
            this.btnCapNhatSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhatSP.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCapNhatSP.ForeColor = System.Drawing.Color.Blue;
            this.btnCapNhatSP.Location = new System.Drawing.Point(1501, 182);
            this.btnCapNhatSP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCapNhatSP.Name = "btnCapNhatSP";
            this.btnCapNhatSP.Size = new System.Drawing.Size(276, 62);
            this.btnCapNhatSP.TabIndex = 69;
            this.btnCapNhatSP.Text = "Cập nhật sản phẩm";
            this.btnCapNhatSP.UseVisualStyleBackColor = false;
            this.btnCapNhatSP.Click += new System.EventHandler(this.btnCapNhatSP_Click);
            // 
            // btnThemSP
            // 
            this.btnThemSP.BackColor = System.Drawing.Color.Transparent;
            this.btnThemSP.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnThemSP.FlatAppearance.BorderSize = 2;
            this.btnThemSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemSP.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnThemSP.Location = new System.Drawing.Point(1501, 91);
            this.btnThemSP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(276, 62);
            this.btnThemSP.TabIndex = 68;
            this.btnThemSP.Text = "Thêm sản phẩm";
            this.btnThemSP.UseVisualStyleBackColor = false;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // txtMoTa
            // 
            this.txtMoTa.BackColor = System.Drawing.SystemColors.Control;
            this.txtMoTa.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoTa.Location = new System.Drawing.Point(258, 351);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(373, 45);
            this.txtMoTa.TabIndex = 67;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(167, 354);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 34);
            this.label9.TabIndex = 66;
            this.label9.Text = "Mô tả:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BackColor = System.Drawing.SystemColors.Control;
            this.txtSoLuong.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(958, 193);
            this.txtSoLuong.Multiline = true;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(373, 45);
            this.txtSoLuong.TabIndex = 65;
            // 
            // dtHSD
            // 
            this.dtHSD.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtHSD.Location = new System.Drawing.Point(958, 267);
            this.dtHSD.Name = "dtHSD";
            this.dtHSD.Size = new System.Drawing.Size(373, 42);
            this.dtHSD.TabIndex = 64;
            // 
            // dtNSX
            // 
            this.dtNSX.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.dtNSX.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNSX.Location = new System.Drawing.Point(258, 267);
            this.dtNSX.Name = "dtNSX";
            this.dtNSX.Size = new System.Drawing.Size(373, 42);
            this.dtNSX.TabIndex = 63;
            // 
            // cbbCatename
            // 
            this.cbbCatename.BackColor = System.Drawing.SystemColors.Control;
            this.cbbCatename.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCatename.FormattingEnabled = true;
            this.cbbCatename.Location = new System.Drawing.Point(258, 201);
            this.cbbCatename.Name = "cbbCatename";
            this.cbbCatename.Size = new System.Drawing.Size(373, 42);
            this.cbbCatename.TabIndex = 62;
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.bAKERYDataSet;
            // 
            // bAKERYDataSet
            // 
            this.bAKERYDataSet.DataSetName = "BAKERYDataSet";
            this.bAKERYDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbbNPP
            // 
            this.cbbNPP.BackColor = System.Drawing.SystemColors.Control;
            this.cbbNPP.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbNPP.FormattingEnabled = true;
            this.cbbNPP.Location = new System.Drawing.Point(258, 119);
            this.cbbNPP.Name = "cbbNPP";
            this.cbbNPP.Size = new System.Drawing.Size(373, 42);
            this.cbbNPP.TabIndex = 61;
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "Supplier";
            this.supplierBindingSource.DataSource = this.bAKERYDataSet;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.BackColor = System.Drawing.SystemColors.Control;
            this.txtGiaBan.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaBan.Location = new System.Drawing.Point(958, 108);
            this.txtGiaBan.Multiline = true;
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(373, 45);
            this.txtGiaBan.TabIndex = 60;
            // 
            // txtGiaGoc
            // 
            this.txtGiaGoc.BackColor = System.Drawing.SystemColors.Control;
            this.txtGiaGoc.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaGoc.Location = new System.Drawing.Point(958, 34);
            this.txtGiaGoc.Multiline = true;
            this.txtGiaGoc.Name = "txtGiaGoc";
            this.txtGiaGoc.Size = new System.Drawing.Size(373, 45);
            this.txtGiaGoc.TabIndex = 59;
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.BackColor = System.Drawing.SystemColors.Control;
            this.txtTenSanPham.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSanPham.Location = new System.Drawing.Point(258, 34);
            this.txtTenSanPham.Multiline = true;
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Size = new System.Drawing.Size(373, 45);
            this.txtTenSanPham.TabIndex = 58;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(787, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 34);
            this.label8.TabIndex = 57;
            this.label8.Text = "Hạn sử dụng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(831, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 34);
            this.label7.TabIndex = 56;
            this.label7.Text = "Số lượng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(846, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 34);
            this.label6.TabIndex = 55;
            this.label6.Text = "Giá bán:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(846, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 34);
            this.label5.TabIndex = 54;
            this.label5.Text = "Giá gốc:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 34);
            this.label4.TabIndex = 53;
            this.label4.Text = "Ngày sản xuất:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(114, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 34);
            this.label3.TabIndex = 52;
            this.label3.Text = "Danh mục:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 34);
            this.label1.TabIndex = 51;
            this.label1.Text = "Nhà phân phối:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 34);
            this.label2.TabIndex = 50;
            this.label2.Text = "Tên sản phẩm:";
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToDeleteRows = false;
            this.dgvProduct.AllowUserToResizeColumns = false;
            this.dgvProduct.AllowUserToResizeRows = false;
            this.dgvProduct.AutoGenerateColumns = false;
            this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProduct.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pro_id,
            this.proName,
            this.categoriesID,
            this.supplierID,
            this.proQuantity,
            this.proFirstPrice,
            this.proPrice,
            this.proNSX,
            this.proHSD,
            this.proDescription});
            this.dgvProduct.DataSource = this.productBindingSource;
            this.dgvProduct.Location = new System.Drawing.Point(76, 414);
            this.dgvProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowHeadersWidth = 62;
            this.dgvProduct.Size = new System.Drawing.Size(1274, 526);
            this.dgvProduct.TabIndex = 49;
            this.dgvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellClick);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.bAKERYDataSet;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // pro_id
            // 
            this.pro_id.DataPropertyName = "id";
            this.pro_id.HeaderText = "ID";
            this.pro_id.MinimumWidth = 12;
            this.pro_id.Name = "pro_id";
            this.pro_id.ReadOnly = true;
            this.pro_id.Width = 62;
            // 
            // proName
            // 
            this.proName.DataPropertyName = "pro_name";
            this.proName.HeaderText = "Tên sản phẩm";
            this.proName.MinimumWidth = 12;
            this.proName.Name = "proName";
            this.proName.Width = 146;
            // 
            // categoriesID
            // 
            this.categoriesID.DataPropertyName = "cate_name";
            this.categoriesID.HeaderText = "Danh mục";
            this.categoriesID.MinimumWidth = 12;
            this.categoriesID.Name = "categoriesID";
            this.categoriesID.Width = 118;
            // 
            // supplierID
            // 
            this.supplierID.DataPropertyName = "sup_name";
            this.supplierID.HeaderText = "Nhà phân phối";
            this.supplierID.MinimumWidth = 12;
            this.supplierID.Name = "supplierID";
            this.supplierID.Width = 148;
            // 
            // proQuantity
            // 
            this.proQuantity.DataPropertyName = "pro_quantity";
            this.proQuantity.HeaderText = "Số lượng";
            this.proQuantity.MinimumWidth = 12;
            this.proQuantity.Name = "proQuantity";
            this.proQuantity.Width = 108;
            // 
            // proFirstPrice
            // 
            this.proFirstPrice.DataPropertyName = "pro_firstprice";
            this.proFirstPrice.HeaderText = "Giá nhập";
            this.proFirstPrice.MinimumWidth = 12;
            this.proFirstPrice.Name = "proFirstPrice";
            this.proFirstPrice.Width = 110;
            // 
            // proPrice
            // 
            this.proPrice.DataPropertyName = "pro_price";
            this.proPrice.HeaderText = "Giá bán";
            this.proPrice.MinimumWidth = 12;
            this.proPrice.Name = "proPrice";
            this.proPrice.Width = 101;
            // 
            // proNSX
            // 
            this.proNSX.DataPropertyName = "pro_nsx";
            this.proNSX.HeaderText = "Ngày sản xuất";
            this.proNSX.MinimumWidth = 12;
            this.proNSX.Name = "proNSX";
            this.proNSX.Width = 145;
            // 
            // proHSD
            // 
            this.proHSD.DataPropertyName = "pro_hsd";
            this.proHSD.HeaderText = "Hạn sử dụng";
            this.proHSD.MinimumWidth = 12;
            this.proHSD.Name = "proHSD";
            this.proHSD.Width = 136;
            // 
            // proDescription
            // 
            this.proDescription.DataPropertyName = "pro_description";
            this.proDescription.HeaderText = "Mô tả";
            this.proDescription.MinimumWidth = 12;
            this.proDescription.Name = "proDescription";
            this.proDescription.Width = 85;
            // 
            // DSSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "DSSanPham";
            this.Size = new System.Drawing.Size(1918, 965);
            this.Load += new System.EventHandler(this.DSSanPham_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAKERYDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.BindingSource productBindingSource;
        private BAKERYDataSet bAKERYDataSet;
        private BAKERYDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnXoaSP;
        private System.Windows.Forms.Button btnCapNhatSP;
        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.DateTimePicker dtHSD;
        private System.Windows.Forms.DateTimePicker dtNSX;
        private System.Windows.Forms.ComboBox cbbCatename;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private System.Windows.Forms.ComboBox cbbNPP;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtGiaGoc;
        private System.Windows.Forms.TextBox txtTenSanPham;
        private BAKERYDataSetTableAdapters.SupplierTableAdapter supplierTableAdapter;
        private BAKERYDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn proName;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriesID;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierID;
        private System.Windows.Forms.DataGridViewTextBoxColumn proQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn proFirstPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn proPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn proNSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn proHSD;
        private System.Windows.Forms.DataGridViewTextBoxColumn proDescription;
    }
}
