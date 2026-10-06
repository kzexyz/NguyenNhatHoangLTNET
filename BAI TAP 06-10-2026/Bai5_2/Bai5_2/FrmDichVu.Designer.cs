
namespace Bai5_2
{
    partial class FrmDichVu
    {
        private System.ComponentModel.IContainer components = null;
        private ComboBox cboCategory;
        private ListBox lstAvailableServices;
        private ListBox lstSelectedServices;
        private Button btnSelect;
        private Button btnRemove;
        private Button btnClearAll;
        private Label lblCategory;
        private Label lblAvailable;
        private Label lblSelected;
        private GroupBox grpPayment;
        private Label lblSubtotal;
        private Label lblSubtotalValue;
        private Label lblDiscount;
        private Label lblDiscountValue;
        private Label lblFinal;
        private Label lblFinalValue;
        private Label lblTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblTitle = new Label();
            lblCategory = new Label();
            cboCategory = new ComboBox();
            lblAvailable = new Label();
            lblSelected = new Label();
            lstAvailableServices = new ListBox();
            lstSelectedServices = new ListBox();
            btnSelect = new Button();
            btnRemove = new Button();
            btnClearAll = new Button();
            grpPayment = new GroupBox();
            lblSubtotal = new Label();
            lblSubtotalValue = new Label();
            lblDiscount = new Label();
            lblDiscountValue = new Label();
            lblFinal = new Label();
            lblFinalValue = new Label();
            grpPayment.SuspendLayout();
            SuspendLayout();
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.Location = new Point(170, 20);
            lblTitle.Text = "BẢNG TÍNH TIỀN DỊCH VỤ";
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(30, 82);
            lblCategory.Text = "Loại dịch vụ:";
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.Location = new Point(130, 78);
            cboCategory.Size = new Size(220, 23);
            cboCategory.SelectedIndexChanged += cboCategory_SelectedIndexChanged;
            lblAvailable.AutoSize = true;
            lblAvailable.Location = new Point(30, 125);
            lblAvailable.Text = "Dịch vụ có sẵn";
            lblSelected.AutoSize = true;
            lblSelected.Location = new Point(425, 125);
            lblSelected.Text = "Dịch vụ đã chọn";
            lstAvailableServices.Location = new Point(30, 150);
            lstAvailableServices.Size = new Size(280, 230);
            lstAvailableServices.DoubleClick += lstAvailableServices_DoubleClick;
            lstSelectedServices.Location = new Point(425, 150);
            lstSelectedServices.Size = new Size(280, 230);
            btnSelect.Location = new Point(335, 190);
            btnSelect.Size = new Size(65, 35);
            btnSelect.Text = ">";
            btnSelect.Click += btnSelect_Click;
            btnRemove.Location = new Point(335, 240);
            btnRemove.Size = new Size(65, 35);
            btnRemove.Text = "<";
            btnRemove.Click += btnRemove_Click;
            btnClearAll.Location = new Point(335, 290);
            btnClearAll.Size = new Size(65, 35);
            btnClearAll.Text = "<<";
            btnClearAll.Click += btnClearAll_Click;
            grpPayment.Location = new Point(30, 405);
            grpPayment.Size = new Size(675, 130);
            grpPayment.Text = "Thanh toán";
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(25, 32);
            lblSubtotal.Text = "Tổng tiền chưa giảm:";
            lblSubtotalValue.AutoSize = true;
            lblSubtotalValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSubtotalValue.Location = new Point(220, 32);
            lblDiscount.AutoSize = true;
            lblDiscount.Location = new Point(25, 62);
            lblDiscount.Text = "Tỷ lệ chiết khấu:";
            lblDiscountValue.AutoSize = true;
            lblDiscountValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDiscountValue.Location = new Point(220, 62);
            lblFinal.AutoSize = true;
            lblFinal.Location = new Point(25, 92);
            lblFinal.Text = "Thành tiền thanh toán:";
            lblFinalValue.AutoSize = true;
            lblFinalValue.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblFinalValue.Location = new Point(220, 90);
            grpPayment.Controls.AddRange(new Control[]{lblSubtotal,lblSubtotalValue,lblDiscount,lblDiscountValue,lblFinal,lblFinalValue});
            ClientSize = new Size(740, 565);
            Controls.AddRange(new Control[]{lblTitle,lblCategory,cboCategory,lblAvailable,lblSelected,lstAvailableServices,lstSelectedServices,btnSelect,btnRemove,btnClearAll,grpPayment});
            Name = "FrmDichVu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 5.2 - Tính tiền dịch vụ";
            grpPayment.ResumeLayout(false);
            grpPayment.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
