
namespace ProjectBakery.GUI_Layer
{
    partial class ThongKeBaoCao
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
            this.rdAll = new System.Windows.Forms.RadioButton();
            this.rdDate = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.btnOK = new System.Windows.Forms.Button();
            this.dgvDSTransaction = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bAKERYDataSet = new ProjectBakery.BAKERYDataSet();
            this.transactionsTableAdapter = new ProjectBakery.BAKERYDataSetTableAdapters.TransactionsTableAdapter();
            this.dgvOrderDetail = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ususernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orquantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new ProjectBakery.BAKERYDataSetTableAdapters.OrdersTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTongDon = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTransaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAKERYDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rdAll
            // 
            this.rdAll.AutoSize = true;
            this.rdAll.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdAll.Location = new System.Drawing.Point(70, 38);
            this.rdAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdAll.Name = "rdAll";
            this.rdAll.Size = new System.Drawing.Size(114, 38);
            this.rdAll.TabIndex = 39;
            this.rdAll.TabStop = true;
            this.rdAll.Text = "Tất cả";
            this.rdAll.UseVisualStyleBackColor = true;
            // 
            // rdDate
            // 
            this.rdDate.AutoSize = true;
            this.rdDate.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdDate.Location = new System.Drawing.Point(264, 38);
            this.rdDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdDate.Name = "rdDate";
            this.rdDate.Size = new System.Drawing.Size(166, 38);
            this.rdDate.TabIndex = 40;
            this.rdDate.TabStop = true;
            this.rdDate.Text = "Theo ngày";
            this.rdDate.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(533, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 34);
            this.label1.TabIndex = 41;
            this.label1.Text = "Từ ngày:";
            // 
            // dateFrom
            // 
            this.dateFrom.CustomFormat = "yyyy-MM-dd";
            this.dateFrom.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFrom.Location = new System.Drawing.Point(653, 38);
            this.dateFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(298, 42);
            this.dateFrom.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1118, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 34);
            this.label2.TabIndex = 43;
            this.label2.Text = "Đến ngày:";
            // 
            // dateTo
            // 
            this.dateTo.CustomFormat = "yyyy-MM-dd";
            this.dateTo.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTo.Location = new System.Drawing.Point(1253, 44);
            this.dateTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(298, 42);
            this.dateTo.TabIndex = 44;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOK.FlatAppearance.BorderSize = 2;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOK.Location = new System.Drawing.Point(1659, 37);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(195, 58);
            this.btnOK.TabIndex = 45;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // dgvDSTransaction
            // 
            this.dgvDSTransaction.AllowUserToAddRows = false;
            this.dgvDSTransaction.AutoGenerateColumns = false;
            this.dgvDSTransaction.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvDSTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSTransaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.addressToDataGridViewTextBoxColumn,
            this.phoneToDataGridViewTextBoxColumn,
            this.totalpriceDataGridViewTextBoxColumn,
            this.createdateDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn});
            this.dgvDSTransaction.DataSource = this.transactionsBindingSource;
            this.dgvDSTransaction.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvDSTransaction.Location = new System.Drawing.Point(39, 103);
            this.dgvDSTransaction.Name = "dgvDSTransaction";
            this.dgvDSTransaction.RowHeadersWidth = 62;
            this.dgvDSTransaction.RowTemplate.Height = 28;
            this.dgvDSTransaction.Size = new System.Drawing.Size(976, 677);
            this.dgvDSTransaction.TabIndex = 48;
            this.dgvDSTransaction.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSTransaction_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Mã chi tiết";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 150;
            // 
            // addressToDataGridViewTextBoxColumn
            // 
            this.addressToDataGridViewTextBoxColumn.DataPropertyName = "addressTo";
            this.addressToDataGridViewTextBoxColumn.HeaderText = "Địa chỉ";
            this.addressToDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.addressToDataGridViewTextBoxColumn.Name = "addressToDataGridViewTextBoxColumn";
            this.addressToDataGridViewTextBoxColumn.Width = 150;
            // 
            // phoneToDataGridViewTextBoxColumn
            // 
            this.phoneToDataGridViewTextBoxColumn.DataPropertyName = "phoneTo";
            this.phoneToDataGridViewTextBoxColumn.HeaderText = "Số điện thoại";
            this.phoneToDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.phoneToDataGridViewTextBoxColumn.Name = "phoneToDataGridViewTextBoxColumn";
            this.phoneToDataGridViewTextBoxColumn.Width = 150;
            // 
            // totalpriceDataGridViewTextBoxColumn
            // 
            this.totalpriceDataGridViewTextBoxColumn.DataPropertyName = "totalprice";
            this.totalpriceDataGridViewTextBoxColumn.HeaderText = "Tổng giá";
            this.totalpriceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.totalpriceDataGridViewTextBoxColumn.Name = "totalpriceDataGridViewTextBoxColumn";
            this.totalpriceDataGridViewTextBoxColumn.Width = 150;
            // 
            // createdateDataGridViewTextBoxColumn
            // 
            this.createdateDataGridViewTextBoxColumn.DataPropertyName = "createdate";
            this.createdateDataGridViewTextBoxColumn.HeaderText = "Ngày lập đơn";
            this.createdateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.createdateDataGridViewTextBoxColumn.Name = "createdateDataGridViewTextBoxColumn";
            this.createdateDataGridViewTextBoxColumn.Width = 150;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "Ghi chú";
            this.noteDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            this.noteDataGridViewTextBoxColumn.Width = 150;
            // 
            // transactionsBindingSource
            // 
            this.transactionsBindingSource.DataMember = "Transactions";
            this.transactionsBindingSource.DataSource = this.bAKERYDataSet;
            // 
            // bAKERYDataSet
            // 
            this.bAKERYDataSet.DataSetName = "BAKERYDataSet";
            this.bAKERYDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transactionsTableAdapter
            // 
            this.transactionsTableAdapter.ClearBeforeFill = true;
            // 
            // dgvOrderDetail
            // 
            this.dgvOrderDetail.AllowUserToAddRows = false;
            this.dgvOrderDetail.AutoGenerateColumns = false;
            this.dgvOrderDetail.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.ususernameDataGridViewTextBoxColumn,
            this.orquantityDataGridViewTextBoxColumn,
            this.orpriceDataGridViewTextBoxColumn});
            this.dgvOrderDetail.DataSource = this.ordersBindingSource;
            this.dgvOrderDetail.Location = new System.Drawing.Point(1162, 103);
            this.dgvOrderDetail.Name = "dgvOrderDetail";
            this.dgvOrderDetail.RowHeadersWidth = 62;
            this.dgvOrderDetail.RowTemplate.Height = 28;
            this.dgvOrderDetail.Size = new System.Drawing.Size(692, 677);
            this.dgvOrderDetail.TabIndex = 49;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Mã hóa đơn";
            this.idDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Width = 150;
            // 
            // ususernameDataGridViewTextBoxColumn
            // 
            this.ususernameDataGridViewTextBoxColumn.DataPropertyName = "us_username";
            this.ususernameDataGridViewTextBoxColumn.HeaderText = "Tên khách hàng";
            this.ususernameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ususernameDataGridViewTextBoxColumn.Name = "ususernameDataGridViewTextBoxColumn";
            this.ususernameDataGridViewTextBoxColumn.Width = 170;
            // 
            // orquantityDataGridViewTextBoxColumn
            // 
            this.orquantityDataGridViewTextBoxColumn.DataPropertyName = "or_quantity";
            this.orquantityDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.orquantityDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.orquantityDataGridViewTextBoxColumn.Name = "orquantityDataGridViewTextBoxColumn";
            this.orquantityDataGridViewTextBoxColumn.Width = 150;
            // 
            // orpriceDataGridViewTextBoxColumn
            // 
            this.orpriceDataGridViewTextBoxColumn.DataPropertyName = "or_price";
            this.orpriceDataGridViewTextBoxColumn.HeaderText = "Giá tiền";
            this.orpriceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.orpriceDataGridViewTextBoxColumn.Name = "orpriceDataGridViewTextBoxColumn";
            this.orpriceDataGridViewTextBoxColumn.Width = 150;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.bAKERYDataSet;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(88, 828);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 46);
            this.label4.TabIndex = 50;
            this.label4.Text = "Tổng đơn:";
            // 
            // lblTongDon
            // 
            this.lblTongDon.AutoSize = true;
            this.lblTongDon.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongDon.Location = new System.Drawing.Point(280, 827);
            this.lblTongDon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongDon.Name = "lblTongDon";
            this.lblTongDon.Size = new System.Drawing.Size(82, 47);
            this.lblTongDon.TabIndex = 52;
            this.lblTongDon.Text = "null";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(583, 828);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 46);
            this.label5.TabIndex = 53;
            this.label5.Text = "Tổng tiền:";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(786, 827);
            this.lblTongTien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(82, 47);
            this.lblTongTien.TabIndex = 54;
            this.lblTongTien.Text = "null";
            // 
            // ThongKeBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTongDon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvOrderDetail);
            this.Controls.Add(this.dgvDSTransaction);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dateTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateFrom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdDate);
            this.Controls.Add(this.rdAll);
            this.Name = "ThongKeBaoCao";
            this.Size = new System.Drawing.Size(1884, 915);
            this.Load += new System.EventHandler(this.ThongKeBaoCao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTransaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAKERYDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdAll;
        private System.Windows.Forms.RadioButton rdDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DataGridView dgvDSTransaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressToDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneToDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource transactionsBindingSource;
        private BAKERYDataSet bAKERYDataSet;
        private BAKERYDataSetTableAdapters.TransactionsTableAdapter transactionsTableAdapter;
        private System.Windows.Forms.DataGridView dgvOrderDetail;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private BAKERYDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ususernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orquantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTongDon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTongTien;
    }
}
