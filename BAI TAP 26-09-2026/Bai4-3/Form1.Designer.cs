using System.Drawing;
using System.Windows.Forms;

namespace Bai4_3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitle = new Label();

            lblId = new Label();
            lblName = new Label();
            lblPrice = new Label();
            lblQuantity = new Label();

            txtId = new TextBox();
            txtName = new TextBox();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();

            btnAdd = new Button();
            btnDelete = new Button();
            btnClear = new Button();

            dgvProduct = new DataGridView();

            colId = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            colQuantity = new DataGridViewTextBoxColumn();

            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();

            SuspendLayout();

            // lblTitle
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font(
                "Segoe UI",
                18F,
                FontStyle.Bold
            );
            lblTitle.Location = new Point(220, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(275, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "QUẢN LÝ SẢN PHẨM";

            // lblId
            lblId.AutoSize = true;
            lblId.Font = new System.Drawing.Font(
                "Segoe UI",
                10F,
                FontStyle.Regular
            );
            lblId.Location = new Point(35, 90);
            lblId.Name = "lblId";
            lblId.Size = new Size(52, 19);
            lblId.TabIndex = 1;
            lblId.Text = "Mã SP:";

            // txtId
            txtId.Font = new System.Drawing.Font(
                "Segoe UI",
                10F,
                FontStyle.Regular
            );
            txtId.Location = new Point(110, 86);
            txtId.Name = "txtId";
            txtId.Size = new Size(210, 25);
            txtId.TabIndex = 2;

            // lblName
            lblName.AutoSize = true;
            lblName.Font = new System.Drawing.Font(
                "Segoe UI",
                10F,
                FontStyle.Regular
            );
            lblName.Location = new Point(370, 90);
            lblName.Name = "lblName";
            lblName.Size = new Size(53, 19);
            lblName.TabIndex = 3;
            lblName.Text = "Tên SP:";

            // txtName
            txtName.Font = new System.Drawing.Font(
                "Segoe UI",
                10F,
                FontStyle.Regular
            );
            txtName.Location = new Point(445, 86);
            txtName.Name = "txtName";
            txtName.Size = new Size(230, 25);
            txtName.TabIndex = 4;

            // lblPrice
            lblPrice.AutoSize = true;
            lblPrice.Font = new System.Drawing.Font(
                "Segoe UI",
                10F,
                FontStyle.Regular
            );
            lblPrice.Location = new Point(35, 140);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(59, 19);
            lblPrice.TabIndex = 5;
            lblPrice.Text = "Đơn giá:";

            // txtPrice
            txtPrice.Font = new System.Drawing.Font(
                "Segoe UI",
                10F,
                FontStyle.Regular
            );
            txtPrice.Location = new Point(110, 136);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(210, 25);
            txtPrice.TabIndex = 6;

            // lblQuantity
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new System.Drawing.Font(
                "Segoe UI",
                10F,
                FontStyle.Regular
            );
            lblQuantity.Location = new Point(370, 140);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(67, 19);
            lblQuantity.TabIndex = 7;
            lblQuantity.Text = "Số lượng:";

            // txtQuantity
            txtQuantity.Font = new System.Drawing.Font(
                "Segoe UI",
                10F,
                FontStyle.Regular
            );
            txtQuantity.Location = new Point(445, 136);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(230, 25);
            txtQuantity.TabIndex = 8;

            // btnAdd
            btnAdd.Font = new System.Drawing.Font(
                "Segoe UI",
                10F,
                FontStyle.Bold
            );
            btnAdd.Location = new Point(180, 190);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(110, 40);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "THÊM";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;

            // btnDelete
            btnDelete.Font = new System.Drawing.Font(
                "Segoe UI",
                10F,
                FontStyle.Bold
            );
            btnDelete.Location = new Point(305, 190);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(110, 40);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "XÓA";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;

            // btnClear
            btnClear.Font = new System.Drawing.Font(
                "Segoe UI",
                10F,
                FontStyle.Regular
            );
            btnClear.Location = new Point(430, 190);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(110, 40);
            btnClear.TabIndex = 11;
            btnClear.Text = "LÀM MỚI";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;

            // colId
            colId.DataPropertyName = "Id";
            colId.HeaderText = "Mã sản phẩm";
            colId.Name = "colId";
            colId.Width = 120;

            // colName
            colName.AutoSizeMode =
                DataGridViewAutoSizeColumnMode.Fill;
            colName.DataPropertyName = "Name";
            colName.HeaderText = "Tên sản phẩm";
            colName.Name = "colName";

            // colPrice
            colPrice.DataPropertyName = "Price";
            colPrice.HeaderText = "Đơn giá";
            colPrice.Name = "colPrice";
            colPrice.Width = 130;

            // colQuantity
            colQuantity.DataPropertyName = "Quantity";
            colQuantity.HeaderText = "Số lượng";
            colQuantity.Name = "colQuantity";
            colQuantity.Width = 100;

            // dgvProduct
            dgvProduct.AllowUserToAddRows = false;

            dgvProduct.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Bottom |
                AnchorStyles.Left |
                AnchorStyles.Right;

            dgvProduct.AutoGenerateColumns = false;

            dgvProduct.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            dgvProduct.Columns.AddRange(
                new DataGridViewColumn[]
                {
                    colId,
                    colName,
                    colPrice,
                    colQuantity
                }
            );

            dgvProduct.Location = new Point(35, 260);

            dgvProduct.MultiSelect = false;

            dgvProduct.Name = "dgvProduct";

            dgvProduct.ReadOnly = false;

            dgvProduct.RowHeadersWidth = 51;

            dgvProduct.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvProduct.Size = new Size(640, 250);

            dgvProduct.TabIndex = 12;

            // Form1
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;

            ClientSize = new Size(715, 545);

            Controls.Add(lblTitle);

            Controls.Add(lblId);
            Controls.Add(txtId);

            Controls.Add(lblName);
            Controls.Add(txtName);

            Controls.Add(lblPrice);
            Controls.Add(txtPrice);

            Controls.Add(lblQuantity);
            Controls.Add(txtQuantity);

            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);

            Controls.Add(dgvProduct);

            MinimumSize = new Size(650, 500);

            Name = "Form1";

            StartPosition =
                FormStartPosition.CenterScreen;

            Text = "Bài 4.3 - Quản lý sản phẩm";

            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;

        private Label lblId;
        private Label lblName;
        private Label lblPrice;
        private Label lblQuantity;

        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtPrice;
        private TextBox txtQuantity;

        private Button btnAdd;
        private Button btnDelete;
        private Button btnClear;

        private DataGridView dgvProduct;

        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewTextBoxColumn colQuantity;
    }
}