
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Bai5_3
{
    public partial class FrmProduct : Form
    {
        private readonly BindingList<Product> products = new();
        private readonly BindingSource source = new();
        private Product? selectedProduct;

        public FrmProduct()
        {
            InitializeComponent();
            source.DataSource = products;
            dgvProducts.DataSource = source;
        }

        private bool TryReadForm(out Product p)
        {
            p = new Product();
            if (string.IsNullOrWhiteSpace(txtId.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text) ||
                !decimal.TryParse(txtPrice.Text, out var price) || price < 0 ||
                !int.TryParse(txtQuantity.Text, out var qty) || qty < 0 ||
                string.IsNullOrWhiteSpace(txtCategory.Text))
            {
                MessageBox.Show("Vui lòng nhập dữ liệu hợp lệ.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            p.ProductId = txtId.Text.Trim();
            p.ProductName = txtName.Text.Trim();
            p.UnitPrice = price;
            p.Quantity = qty;
            p.Category = txtCategory.Text.Trim();
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!TryReadForm(out var p)) return;
            if (products.Any(x => x.ProductId.Equals(p.ProductId, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Mã sản phẩm đã tồn tại.");
                return;
            }
            products.Add(p);
            ClearForm();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedProduct == null || !TryReadForm(out var p)) return;
            selectedProduct.ProductId = p.ProductId;
            selectedProduct.ProductName = p.ProductName;
            selectedProduct.UnitPrice = p.UnitPrice;
            selectedProduct.Quantity = p.Quantity;
            selectedProduct.Category = p.Category;
            source.ResetBindings(false);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedProduct == null) return;
            if (MessageBox.Show("Bạn có chắc muốn xóa sản phẩm này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                products.Remove(selectedProduct);
                ClearForm();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            if (keyword.Length == 0)
            {
                source.DataSource = products;
                return;
            }

            var filtered = products.Where(p =>
                p.ProductName.Contains(keyword, StringComparison.OrdinalIgnoreCase)).ToList();
            source.DataSource = new BindingList<Product>(filtered);
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvProducts.Rows[e.RowIndex].DataBoundItem is Product p)
            {
                selectedProduct = p;
                txtId.Text = p.ProductId;
                txtName.Text = p.ProductName;
                txtPrice.Text = p.UnitPrice.ToString("0");
                txtQuantity.Text = p.Quantity.ToString();
                txtCategory.Text = p.Category;
            }
        }

        private void dgvProducts_MouseDown(object sender, MouseEventArgs e)
        {
            var hit = dgvProducts.HitTest(e.X, e.Y);

            // Bấm vào vùng xám trống bên dưới dữ liệu -> bỏ chọn để nhập sản phẩm mới
            if (hit.Type == DataGridViewHitTestType.None)
            {
                ClearForm();
            }
        }

        private void ClearForm()
        {
            selectedProduct = null;
            dgvProducts.ClearSelection();
            dgvProducts.CurrentCell = null;
            txtId.Clear();
            txtName.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
            txtCategory.Clear();
            txtId.Focus();
        }
    }
}
