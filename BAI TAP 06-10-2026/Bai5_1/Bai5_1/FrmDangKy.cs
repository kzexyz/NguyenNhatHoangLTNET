using System;
using System.Windows.Forms;

namespace Bai5_1
{
    public partial class FrmDangKy : Form
    {
        public FrmDangKy()
        {
            InitializeComponent();
            dtpBirthDate.MaxDate = DateTime.Today;
            txtPassword.UseSystemPasswordChar = true;
            txtConfirmPassword.UseSystemPasswordChar = true;
        }

        private bool KiemTraDuLieu()
        {
            bool hopLe = true;
            epCheck.Clear();

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                epCheck.SetError(txtUsername, "Tên đăng nhập không được để trống.");
                hopLe = false;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                epCheck.SetError(txtPassword, "Mật khẩu không được để trống.");
                hopLe = false;
            }

            if (txtConfirmPassword.Text != txtPassword.Text)
            {
                epCheck.SetError(txtConfirmPassword, "Xác nhận mật khẩu không khớp.");
                hopLe = false;
            }

            int tuoi = DateTime.Today.Year - dtpBirthDate.Value.Year;
            if (dtpBirthDate.Value.Date > DateTime.Today.AddYears(-tuoi)) tuoi--;

            if (tuoi < 18)
            {
                epCheck.SetError(dtpBirthDate, "Người đăng ký phải từ 18 tuổi trở lên.");
                hopLe = false;
            }

            if (!chkAgree.Checked)
            {
                epCheck.SetError(chkAgree, "Bạn phải đồng ý với Điều khoản dịch vụ.");
                hopLe = false;
            }

            return hopLe;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieu()) return;

            string gioiTinh = rdoMale.Checked ? "Nam" : rdoFemale.Checked ? "Nữ" : "Chưa chọn";
            MessageBox.Show(
                $"Đăng ký tài khoản thành công!\n\nTên đăng nhập: {txtUsername.Text}\nGiới tính: {gioiTinh}",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            dtpBirthDate.Value = DateTime.Today;
            rdoMale.Checked = false;
            rdoFemale.Checked = false;
            chkAgree.Checked = false;
            epCheck.Clear();
            txtUsername.Focus();
        }
    }
}
