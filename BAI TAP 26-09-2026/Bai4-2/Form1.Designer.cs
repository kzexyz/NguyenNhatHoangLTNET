using System.Drawing;
using System.Windows.Forms;

namespace Bai4_2
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
            components = new System.ComponentModel.Container();

            lblTitle = new Label();

            lblName = new Label();
            lblEmail = new Label();
            lblPhone = new Label();
            lblCourse = new Label();

            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();

            cboCourse = new ComboBox();

            btnSubmit = new Button();
            btnClear = new Button();

            errorProvider1 = new ErrorProvider(components);

            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();

            SuspendLayout();

            // lblTitle
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font(
                "Segoe UI",
                18F,
                FontStyle.Bold
            );
            lblTitle.Location = new Point(105, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(250, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ĐĂNG KÝ HỌC VIÊN";

            // lblName
            lblName.AutoSize = true;
            lblName.Font = new System.Drawing.Font(
                "Segoe UI",
                10F,
                FontStyle.Regular
            );
            lblName.Location = new Point(45, 100);
            lblName.Name = "lblName";
            lblName.Size = new Size(76, 19);
            lblName.TabIndex = 1;
            lblName.Text = "Họ và tên:";

            // txtName
            txtName.Font = new System.Drawing.Font(
                "Segoe UI",
                10F,
                FontStyle.Regular
            );
            txtName.Location = new Point(145, 96);
            txtName.Name = "txtName";
            txtName.Size = new Size(250, 25);
            txtName.TabIndex = 2;

            // lblEmail
            lblEmail.AutoSize = true;
            lblEmail.Font = new System.Drawing.Font(
                "Segoe UI",
                10F,
                FontStyle.Regular
            );
            lblEmail.Location = new Point(45, 150);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(44, 19);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email:";

            // txtEmail
            txtEmail.Font = new System.Drawing.Font(
                "Segoe UI",
                10F,
                FontStyle.Regular
            );
            txtEmail.Location = new Point(145, 146);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(250, 25);
            txtEmail.TabIndex = 4;

            // lblPhone
            lblPhone.AutoSize = true;
            lblPhone.Font = new System.Drawing.Font(
                "Segoe UI",
                10F,
                FontStyle.Regular
            );
            lblPhone.Location = new Point(45, 200);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(93, 19);
            lblPhone.TabIndex = 5;
            lblPhone.Text = "Số điện thoại:";

            // txtPhone
            txtPhone.Font = new System.Drawing.Font(
                "Segoe UI",
                10F,
                FontStyle.Regular
            );
            txtPhone.Location = new Point(145, 196);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(250, 25);
            txtPhone.TabIndex = 6;

            // lblCourse
            lblCourse.AutoSize = true;
            lblCourse.Font = new System.Drawing.Font(
                "Segoe UI",
                10F,
                FontStyle.Regular
            );
            lblCourse.Location = new Point(45, 250);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(71, 19);
            lblCourse.TabIndex = 7;
            lblCourse.Text = "Khóa học:";

            // cboCourse
            cboCourse.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCourse.Font = new System.Drawing.Font(
                "Segoe UI",
                10F,
                FontStyle.Regular
            );
            cboCourse.FormattingEnabled = true;

            cboCourse.Items.AddRange(
                new object[]
                {
                    "Lập trình C#",
                    "Lập trình Java",
                    "Lập trình Web",
                    "Cơ sở dữ liệu",
                    "Điện toán đám mây"
                }
            );

            cboCourse.Location = new Point(145, 246);
            cboCourse.Name = "cboCourse";
            cboCourse.Size = new Size(250, 25);
            cboCourse.TabIndex = 8;

            // btnSubmit
            btnSubmit.Font = new System.Drawing.Font(
                "Segoe UI",
                10F,
                FontStyle.Bold
            );
            btnSubmit.Location = new Point(145, 315);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(110, 42);
            btnSubmit.TabIndex = 9;
            btnSubmit.Text = "SUBMIT";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;

            // btnClear
            btnClear.Font = new System.Drawing.Font(
                "Segoe UI",
                10F,
                FontStyle.Regular
            );
            btnClear.Location = new Point(285, 315);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(110, 42);
            btnClear.TabIndex = 10;
            btnClear.Text = "LÀM MỚI";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;

            // errorProvider1
            errorProvider1.ContainerControl = this;

            // Form1
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;

            ClientSize = new Size(460, 410);

            Controls.Add(lblTitle);

            Controls.Add(lblName);
            Controls.Add(txtName);

            Controls.Add(lblEmail);
            Controls.Add(txtEmail);

            Controls.Add(lblPhone);
            Controls.Add(txtPhone);

            Controls.Add(lblCourse);
            Controls.Add(cboCourse);

            Controls.Add(btnSubmit);
            Controls.Add(btnClear);

            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 4.2 - Đăng ký học viên";

            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;

        private Label lblName;
        private Label lblEmail;
        private Label lblPhone;
        private Label lblCourse;

        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtPhone;

        private ComboBox cboCourse;

        private Button btnSubmit;
        private Button btnClear;

        private ErrorProvider errorProvider1;
    }
}