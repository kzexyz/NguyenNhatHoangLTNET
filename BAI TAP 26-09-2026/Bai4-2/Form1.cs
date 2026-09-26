using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Bai4_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Xóa lỗi cũ
            errorProvider1.Clear();

            bool hopLe = true;

            // Kiểm tra họ tên
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                errorProvider1.SetError(
                    txtName,
                    "Vui lòng nhập họ và tên."
                );

                hopLe = false;
            }

            // Kiểm tra email
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider1.SetError(
                    txtEmail,
                    "Vui lòng nhập email."
                );

                hopLe = false;
            }
            else if (!txtEmail.Text.Contains("@"))
            {
                errorProvider1.SetError(
                    txtEmail,
                    "Email không hợp lệ."
                );

                hopLe = false;
            }

            // Kiểm tra số điện thoại
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                errorProvider1.SetError(
                    txtPhone,
                    "Vui lòng nhập số điện thoại."
                );

                hopLe = false;
            }
            else
            {
                foreach (char c in txtPhone.Text)
                {
                    if (!char.IsDigit(c))
                    {
                        errorProvider1.SetError(
                            txtPhone,
                            "Số điện thoại chỉ được chứa chữ số."
                        );

                        hopLe = false;
                        break;
                    }
                }
            }

            // Kiểm tra khóa học
            if (cboCourse.SelectedIndex == -1)
            {
                errorProvider1.SetError(
                    cboCourse,
                    "Vui lòng chọn khóa học."
                );

                hopLe = false;
            }

            if (hopLe)
            {
                MessageBox.Show(
                    "Đăng ký học viên thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();

            cboCourse.SelectedIndex = -1;

            errorProvider1.Clear();

            txtName.Focus();
        }
    }
}