using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Bai4_5
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();

            cboCourse.SelectedIndex = 0;
            rdoMale.Checked = true;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            bool valid = true;

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                errorProvider1.SetError(
                    txtName,
                    "Vui lòng nhập họ và tên."
                );

                valid = false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider1.SetError(
                    txtEmail,
                    "Vui lòng nhập email."
                );

                valid = false;
            }
            else if (!txtEmail.Text.Contains("@"))
            {
                errorProvider1.SetError(
                    txtEmail,
                    "Email không hợp lệ."
                );

                valid = false;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                errorProvider1.SetError(
                    txtPhone,
                    "Vui lòng nhập số điện thoại."
                );

                valid = false;
            }
            else
            {
                foreach (char c in txtPhone.Text)
                {
                    if (!char.IsDigit(c))
                    {
                        errorProvider1.SetError(
                            txtPhone,
                            "Số điện thoại chỉ được nhập số."
                        );

                        valid = false;
                        break;
                    }
                }
            }

            if (cboCourse.SelectedIndex == -1)
            {
                errorProvider1.SetError(
                    cboCourse,
                    "Vui lòng chọn khóa học."
                );

                valid = false;
            }

            if (!valid)
            {
                return;
            }

            string gender = rdoMale.Checked ? "Nam" : "Nữ";

            MessageBox.Show(
                "Đăng ký thành công!\n\n" +
                "Họ tên: " + txtName.Text + "\n" +
                "Email: " + txtEmail.Text + "\n" +
                "SĐT: " + txtPhone.Text + "\n" +
                "Ngày sinh: " + dtpBirth.Value.ToString("dd/MM/yyyy") + "\n" +
                "Giới tính: " + gender + "\n" +
                "Khóa học: " + cboCourse.Text + "\n" +
                "Địa chỉ: " + txtAddress.Text,
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtAddress.Clear();

            dtpBirth.Value = DateTime.Today;
            rdoMale.Checked = true;
            cboCourse.SelectedIndex = 0;

            errorProvider1.Clear();

            txtName.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}