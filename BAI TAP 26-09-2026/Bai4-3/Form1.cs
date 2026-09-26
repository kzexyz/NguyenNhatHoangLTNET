using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Bai4_3
{
    public partial class Form1 : Form
    {
        private BindingList<ProductModel> danhSachSanPham;

        public Form1()
        {
            InitializeComponent();

            danhSachSanPham = new BindingList<ProductModel>();

            dgvProduct.DataSource = danhSachSanPham;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtPrice.Text) ||
                string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ thông tin sản phẩm.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show(
                    "Đơn giá phải là số.",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            if (!int.TryParse(txtQuantity.Text, out int quantity))
            {
                MessageBox.Show(
                    "Số lượng phải là số nguyên.",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            ProductModel product = new ProductModel
            {
                Id = txtId.Text,
                Name = txtName.Text,
                Price = price,
                Quantity = quantity
            };

            danhSachSanPham.Add(product);

            ClearInput();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProduct.CurrentRow == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn sản phẩm cần xóa.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            ProductModel product =
                dgvProduct.CurrentRow.DataBoundItem as ProductModel;

            if (product != null)
            {
                danhSachSanPham.Remove(product);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        private void ClearInput()
        {
            txtId.Clear();
            txtName.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();

            txtId.Focus();
        }
    }

    public class ProductModel
    {
        public string Id { get; set; } = "";
        public string Name { get; set; } = "";
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}