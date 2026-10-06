namespace Bai5_1
{
    partial class FrmDangKy
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private GroupBox grpInfo;
        private GroupBox grpExtra;
        private Label lblUsername;
        private Label lblPassword;
        private Label lblConfirmPassword;
        private Label lblBirthDate;
        private Label lblGender;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private DateTimePicker dtpBirthDate;
        private RadioButton rdoMale;
        private RadioButton rdoFemale;
        private CheckBox chkAgree;
        private Button btnRegister;
        private Button btnReset;
        private ErrorProvider epCheck;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblTitle = new Label();
            grpInfo = new GroupBox();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblConfirmPassword = new Label();
            txtConfirmPassword = new TextBox();
            grpExtra = new GroupBox();
            lblBirthDate = new Label();
            dtpBirthDate = new DateTimePicker();
            lblGender = new Label();
            rdoMale = new RadioButton();
            rdoFemale = new RadioButton();
            chkAgree = new CheckBox();
            btnRegister = new Button();
            btnReset = new Button();
            epCheck = new ErrorProvider(components);
            grpInfo.SuspendLayout();
            grpExtra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)epCheck).BeginInit();
            SuspendLayout();

            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.Location = new Point(136, 24);
            lblTitle.Text = "ĐĂNG KÝ TÀI KHOẢN";

            grpInfo.Controls.Add(lblUsername);
            grpInfo.Controls.Add(txtUsername);
            grpInfo.Controls.Add(lblPassword);
            grpInfo.Controls.Add(txtPassword);
            grpInfo.Controls.Add(lblConfirmPassword);
            grpInfo.Controls.Add(txtConfirmPassword);
            grpInfo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpInfo.Location = new Point(32, 76);
            grpInfo.Size = new Size(516, 178);
            grpInfo.Text = "Thông tin tài khoản";

            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 10F);
            lblUsername.Location = new Point(28, 39);
            lblUsername.Text = "Tên đăng nhập:";

            txtUsername.Font = new Font("Segoe UI", 10F);
            txtUsername.Location = new Point(185, 35);
            txtUsername.Size = new Size(290, 25);

            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 10F);
            lblPassword.Location = new Point(28, 83);
            lblPassword.Text = "Mật khẩu:";

            txtPassword.Font = new Font("Segoe UI", 10F);
            txtPassword.Location = new Point(185, 79);
            txtPassword.Size = new Size(290, 25);
            txtPassword.UseSystemPasswordChar = true;

            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Segoe UI", 10F);
            lblConfirmPassword.Location = new Point(28, 127);
            lblConfirmPassword.Text = "Xác nhận mật khẩu:";

            txtConfirmPassword.Font = new Font("Segoe UI", 10F);
            txtConfirmPassword.Location = new Point(185, 123);
            txtConfirmPassword.Size = new Size(290, 25);
            txtConfirmPassword.UseSystemPasswordChar = true;

            grpExtra.Controls.Add(lblBirthDate);
            grpExtra.Controls.Add(dtpBirthDate);
            grpExtra.Controls.Add(lblGender);
            grpExtra.Controls.Add(rdoMale);
            grpExtra.Controls.Add(rdoFemale);
            grpExtra.Controls.Add(chkAgree);
            grpExtra.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpExtra.Location = new Point(32, 272);
            grpExtra.Size = new Size(516, 176);
            grpExtra.Text = "Thông tin bổ sung";

            lblBirthDate.AutoSize = true;
            lblBirthDate.Font = new Font("Segoe UI", 10F);
            lblBirthDate.Location = new Point(28, 39);
            lblBirthDate.Text = "Ngày sinh:";

            dtpBirthDate.CustomFormat = "dd/MM/yyyy";
            dtpBirthDate.Font = new Font("Segoe UI", 10F);
            dtpBirthDate.Format = DateTimePickerFormat.Custom;
            dtpBirthDate.Location = new Point(185, 35);
            dtpBirthDate.Size = new Size(180, 25);

            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 10F);
            lblGender.Location = new Point(28, 83);
            lblGender.Text = "Giới tính:";

            rdoMale.AutoSize = true;
            rdoMale.Font = new Font("Segoe UI", 10F);
            rdoMale.Location = new Point(185, 81);
            rdoMale.Text = "Nam";

            rdoFemale.AutoSize = true;
            rdoFemale.Font = new Font("Segoe UI", 10F);
            rdoFemale.Location = new Point(260, 81);
            rdoFemale.Text = "Nữ";

            chkAgree.AutoSize = true;
            chkAgree.Font = new Font("Segoe UI", 10F);
            chkAgree.Location = new Point(28, 126);
            chkAgree.Text = "Tôi đồng ý với Điều khoản dịch vụ";

            btnRegister.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRegister.Location = new Point(174, 470);
            btnRegister.Size = new Size(110, 38);
            btnRegister.Text = "Đăng ký";
            btnRegister.Click += btnRegister_Click;

            btnReset.Font = new Font("Segoe UI", 10F);
            btnReset.Location = new Point(300, 470);
            btnReset.Size = new Size(110, 38);
            btnReset.Text = "Làm mới";
            btnReset.Click += btnReset_Click;

            epCheck.ContainerControl = this;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 536);
            Controls.Add(btnReset);
            Controls.Add(btnRegister);
            Controls.Add(grpExtra);
            Controls.Add(grpInfo);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmDangKy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 5.1 - Đăng ký tài khoản";
            grpInfo.ResumeLayout(false);
            grpInfo.PerformLayout();
            grpExtra.ResumeLayout(false);
            grpExtra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)epCheck).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
