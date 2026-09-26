using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private double soThuNhat = 0;
        private string phepTinh = "";
        private bool nhapSoMoi = false;

        public Form1()
        {
            InitializeComponent();
        }

        // Event Sharing cho tất cả nút số 0 -> 9
        private void btnNum_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (txtDisplay.Text == "0" || nhapSoMoi)
            {
                txtDisplay.Text = btn.Text;
                nhapSoMoi = false;
            }
            else
            {
                txtDisplay.Text += btn.Text;
            }
        }

        // Event Sharing cho các phép toán + - * /
        private void btnOperator_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            soThuNhat = double.Parse(txtDisplay.Text);
            phepTinh = btn.Text;
            nhapSoMoi = true;
        }

        // Nút =
        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(phepTinh))
                return;

            double soThuHai = double.Parse(txtDisplay.Text);
            double ketQua = 0;

            switch (phepTinh)
            {
                case "+":
                    ketQua = soThuNhat + soThuHai;
                    break;

                case "-":
                    ketQua = soThuNhat - soThuHai;
                    break;

                case "*":
                    ketQua = soThuNhat * soThuHai;
                    break;

                case "/":
                    if (soThuHai == 0)
                    {
                        MessageBox.Show(
                            "Không thể chia cho 0!",
                            "Lỗi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );

                        txtDisplay.Text = "0";
                        phepTinh = "";
                        soThuNhat = 0;
                        nhapSoMoi = false;
                        return;
                    }

                    ketQua = soThuNhat / soThuHai;
                    break;
            }

            txtDisplay.Text = ketQua.ToString();
            phepTinh = "";
            nhapSoMoi = true;
        }

        // Nút C
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            soThuNhat = 0;
            phepTinh = "";
            nhapSoMoi = false;
        }
    }
}