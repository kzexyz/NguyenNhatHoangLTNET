using System.Drawing;
using System.Windows.Forms;

namespace Bai4_4
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
            lblAvatar = new Label();
            pictureAvatar = new PictureBox();
            lblPath = new Label();
            txtPath = new TextBox();
            btnOpenImage = new Button();
            btnExportCsv = new Button();
            btnClear = new Button();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureAvatar).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.Location = new Point(107, 33);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(355, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Nạp Avatar và Xuất CSV";
            // 
            // lblAvatar
            // 
            lblAvatar.AutoSize = true;
            lblAvatar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAvatar.Location = new Point(246, 93);
            lblAvatar.Name = "lblAvatar";
            lblAvatar.Size = new Size(63, 23);
            lblAvatar.TabIndex = 1;
            lblAvatar.Text = "Avatar";
            // 
            // pictureAvatar
            // 
            pictureAvatar.BorderStyle = BorderStyle.FixedSingle;
            pictureAvatar.Location = new Point(181, 138);
            pictureAvatar.Margin = new Padding(3, 4, 3, 4);
            pictureAvatar.Name = "pictureAvatar";
            pictureAvatar.Size = new Size(191, 286);
            pictureAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            pictureAvatar.TabIndex = 2;
            pictureAvatar.TabStop = false;
            // 
            // lblPath
            // 
            lblPath.AutoSize = true;
            lblPath.Font = new Font("Segoe UI", 10F);
            lblPath.Location = new Point(40, 467);
            lblPath.Name = "lblPath";
            lblPath.Size = new Size(100, 23);
            lblPath.TabIndex = 3;
            lblPath.Text = "Đường dẫn:";
            // 
            // txtPath
            // 
            txtPath.Font = new Font("Segoe UI", 10F);
            txtPath.Location = new Point(143, 463);
            txtPath.Margin = new Padding(3, 4, 3, 4);
            txtPath.Name = "txtPath";
            txtPath.ReadOnly = true;
            txtPath.Size = new Size(377, 30);
            txtPath.TabIndex = 4;
            // 
            // btnOpenImage
            // 
            btnOpenImage.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnOpenImage.Location = new Point(74, 547);
            btnOpenImage.Margin = new Padding(3, 4, 3, 4);
            btnOpenImage.Name = "btnOpenImage";
            btnOpenImage.Size = new Size(137, 56);
            btnOpenImage.TabIndex = 5;
            btnOpenImage.Text = "NẠP ẢNH";
            btnOpenImage.UseVisualStyleBackColor = true;
            btnOpenImage.Click += btnOpenImage_Click;
            // 
            // btnExportCsv
            // 
            btnExportCsv.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnExportCsv.Location = new Point(223, 547);
            btnExportCsv.Margin = new Padding(3, 4, 3, 4);
            btnExportCsv.Name = "btnExportCsv";
            btnExportCsv.Size = new Size(137, 56);
            btnExportCsv.TabIndex = 6;
            btnExportCsv.Text = "XUẤT CSV";
            btnExportCsv.UseVisualStyleBackColor = true;
            btnExportCsv.Click += btnExportCsv_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 10F);
            btnClear.Location = new Point(371, 547);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(137, 56);
            btnClear.TabIndex = 7;
            btnClear.Text = "LÀM MỚI";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png|JPEG Files|*.jpg;*.jpeg|PNG Files|*.png";
            openFileDialog1.Title = "Chọn ảnh Avatar";
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.DefaultExt = "csv";
            saveFileDialog1.Filter = "CSV Files (*.csv)|*.csv";
            saveFileDialog1.Title = "Lưu file CSV";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 667);
            Controls.Add(lblTitle);
            Controls.Add(lblAvatar);
            Controls.Add(pictureAvatar);
            Controls.Add(lblPath);
            Controls.Add(txtPath);
            Controls.Add(btnOpenImage);
            Controls.Add(btnExportCsv);
            Controls.Add(btnClear);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 4.4 - Avatar và CSV";
            ((System.ComponentModel.ISupportInitialize)pictureAvatar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblAvatar;

        private PictureBox pictureAvatar;

        private Label lblPath;
        private TextBox txtPath;

        private Button btnOpenImage;
        private Button btnExportCsv;
        private Button btnClear;

        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}