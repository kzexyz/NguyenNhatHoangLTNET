
namespace Bai5_3
{
    partial class FrmProduct
    {
        private System.ComponentModel.IContainer components = null;
        private GroupBox grpInfo;
        private GroupBox grpFunctions;
        private TextBox txtId, txtName, txtPrice, txtQuantity, txtCategory, txtSearch;
        private Label lblId, lblName, lblPrice, lblQuantity, lblCategory, lblSearch, lblTitle;
        private Button btnAdd, btnEdit, btnDelete, btnSearch;
        private DataGridView dgvProducts;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            grpInfo = new GroupBox();
            lblId = new Label();
            txtId = new TextBox();
            lblName = new Label();
            txtName = new TextBox();
            lblPrice = new Label();
            txtPrice = new TextBox();
            lblQuantity = new Label();
            txtQuantity = new TextBox();
            lblCategory = new Label();
            txtCategory = new TextBox();
            grpFunctions = new GroupBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            dgvProducts = new DataGridView();
            grpInfo.SuspendLayout();
            grpFunctions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.Location = new Point(220, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(254, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "QUẢN LÝ SẢN PHẨM";
            // 
            // grpInfo
            // 
            grpInfo.Controls.Add(lblId);
            grpInfo.Controls.Add(txtId);
            grpInfo.Controls.Add(lblName);
            grpInfo.Controls.Add(txtName);
            grpInfo.Controls.Add(lblPrice);
            grpInfo.Controls.Add(txtPrice);
            grpInfo.Controls.Add(lblQuantity);
            grpInfo.Controls.Add(txtQuantity);
            grpInfo.Controls.Add(lblCategory);
            grpInfo.Controls.Add(txtCategory);
            grpInfo.Location = new Point(25, 70);
            grpInfo.Name = "grpInfo";
            grpInfo.Size = new Size(760, 160);
            grpInfo.TabIndex = 1;
            grpInfo.TabStop = false;
            grpInfo.Text = "Thông tin sản phẩm";
            // 
            // lblId
            // 
            lblId.Location = new Point(20, 35);
            lblId.Name = "lblId";
            lblId.Size = new Size(74, 23);
            lblId.TabIndex = 0;
            lblId.Text = "Mã SP";
            // 
            // txtId
            // 
            txtId.Location = new Point(100, 31);
            txtId.Name = "txtId";
            txtId.Size = new Size(220, 23);
            txtId.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.Location = new Point(390, 35);
            lblName.Name = "lblName";
            lblName.Size = new Size(74, 23);
            lblName.TabIndex = 2;
            lblName.Text = "Tên SP";
            // 
            // txtName
            // 
            txtName.Location = new Point(470, 31);
            txtName.Name = "txtName";
            txtName.Size = new Size(250, 23);
            txtName.TabIndex = 3;
            // 
            // lblPrice
            // 
            lblPrice.Location = new Point(20, 75);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(74, 23);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "Đơn giá";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(100, 71);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(220, 23);
            txtPrice.TabIndex = 5;
            // 
            // lblQuantity
            // 
            lblQuantity.Location = new Point(390, 75);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(74, 23);
            lblQuantity.TabIndex = 6;
            lblQuantity.Text = "Số lượng";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(470, 71);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(250, 23);
            txtQuantity.TabIndex = 7;
            // 
            // lblCategory
            // 
            lblCategory.Location = new Point(20, 115);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(74, 23);
            lblCategory.TabIndex = 8;
            lblCategory.Text = "Danh mục";
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(100, 111);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(220, 23);
            txtCategory.TabIndex = 9;
            // 
            // grpFunctions
            // 
            grpFunctions.Controls.Add(btnAdd);
            grpFunctions.Controls.Add(btnEdit);
            grpFunctions.Controls.Add(btnDelete);
            grpFunctions.Controls.Add(lblSearch);
            grpFunctions.Controls.Add(txtSearch);
            grpFunctions.Controls.Add(btnSearch);
            grpFunctions.Location = new Point(25, 245);
            grpFunctions.Name = "grpFunctions";
            grpFunctions.Size = new Size(760, 85);
            grpFunctions.TabIndex = 2;
            grpFunctions.TabStop = false;
            grpFunctions.Text = "Chức năng";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(20, 31);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(85, 30);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(115, 31);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(85, 30);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Sửa";
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(210, 31);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(85, 30);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Xóa";
            btnDelete.Click += btnDelete_Click;
            // 
            // lblSearch
            // 
            lblSearch.Location = new Point(325, 37);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(59, 23);
            lblSearch.TabIndex = 3;
            lblSearch.Text = "Tìm tên:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(390, 33);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(220, 23);
            txtSearch.TabIndex = 4;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(620, 31);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 30);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.Location = new Point(25, 350);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(760, 260);
            dgvProducts.TabIndex = 3;
            dgvProducts.CellClick += dgvProducts_CellClick;
            dgvProducts.MouseDown += dgvProducts_MouseDown;
            // 
            // FrmProduct
            // 
            ClientSize = new Size(810, 635);
            Controls.Add(lblTitle);
            Controls.Add(grpInfo);
            Controls.Add(grpFunctions);
            Controls.Add(dgvProducts);
            Name = "FrmProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 5.3 - Quản lý sản phẩm";
            grpInfo.ResumeLayout(false);
            grpInfo.PerformLayout();
            grpFunctions.ResumeLayout(false);
            grpFunctions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
