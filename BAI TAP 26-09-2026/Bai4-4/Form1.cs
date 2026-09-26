using System;
using System.IO;
using System.Windows.Forms;

namespace Bai4_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Nạp ảnh bằng OpenFileDialog
        private void btnOpenImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter =
                "Image Files|*.jpg;*.jpeg;*.png|" +
                "JPEG Files|*.jpg;*.jpeg|" +
                "PNG Files|*.png";

            openFileDialog1.Title = "Chọn ảnh Avatar";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = openFileDialog1.FileName;

                pictureAvatar.ImageLocation =
                    openFileDialog1.FileName;

                pictureAvatar.SizeMode =
                    PictureBoxSizeMode.Zoom;
            }
        }

        // Xuất file CSV
        private void btnExportCsv_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter =
                "CSV Files (*.csv)|*.csv";

            saveFileDialog1.DefaultExt = "csv";

            saveFileDialog1.FileName =
                "avatar_data.csv";

            saveFileDialog1.Title =
                "Chọn vị trí lưu file CSV";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter writer =
                        new StreamWriter(
                            saveFileDialog1.FileName,
                            false,
                            System.Text.Encoding.UTF8))
                    {
                        writer.WriteLine("STT,DuongDanAnh");
                        writer.WriteLine(
                            "1,\"" + txtPath.Text + "\""
                        );
                    }

                    MessageBox.Show(
                        "Xuất file CSV thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Không thể lưu file!\n" + ex.Message,
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            pictureAvatar.Image = null;
            pictureAvatar.ImageLocation = null;

            txtPath.Clear();
        }
    }
}