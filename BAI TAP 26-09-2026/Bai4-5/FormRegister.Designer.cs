using System.Drawing;
using System.Windows.Forms;

namespace Bai4_5
{
    partial class FormRegister
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private Label lblName;
        private Label lblEmail;
        private Label lblPhone;
        private Label lblBirth;
        private Label lblGender;
        private Label lblCourse;
        private Label lblAddress;

        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtAddress;

        private DateTimePicker dtpBirth;

        private GroupBox groupGender;
        private RadioButton rdoMale;
        private RadioButton rdoFemale;

        private ComboBox cboCourse;

        private Button btnRegister;
        private Button btnClear;
        private Button btnClose;

        private ErrorProvider errorProvider1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblTitle = new Label();
            lblName = new Label();
            lblEmail = new Label();
            lblPhone = new Label();
            lblBirth = new Label();
            lblGender = new Label();
            lblCourse = new Label();
            lblAddress = new Label();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            dtpBirth = new DateTimePicker();
            groupGender = new GroupBox();
            rdoMale = new RadioButton();
            rdoFemale = new RadioButton();
            cboCourse = new ComboBox();
            btnRegister = new Button();
            btnClear = new Button();
            btnClose = new Button();
            errorProvider1 = new ErrorProvider(components);
            groupGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.Location = new Point(177, 27);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(302, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ĐĂNG KÝ HỌC VIÊN";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(46, 120);
            lblName.Name = "lblName";
            lblName.Size = new Size(76, 20);
            lblName.TabIndex = 1;
            lblName.Text = "Họ và tên:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(46, 180);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(46, 240);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(100, 20);
            lblPhone.TabIndex = 5;
            lblPhone.Text = "Số điện thoại:";
            // 
            // lblBirth
            // 
            lblBirth.AutoSize = true;
            lblBirth.Location = new Point(46, 300);
            lblBirth.Name = "lblBirth";
            lblBirth.Size = new Size(77, 20);
            lblBirth.TabIndex = 7;
            lblBirth.Text = "Ngày sinh:";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(46, 360);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(68, 20);
            lblGender.TabIndex = 9;
            lblGender.Text = "Giới tính:";
            // 
            // lblCourse
            // 
            lblCourse.AutoSize = true;
            lblCourse.Location = new Point(46, 440);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(74, 20);
            lblCourse.TabIndex = 11;
            lblCourse.Text = "Khóa học:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(46, 500);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(58, 20);
            lblAddress.TabIndex = 13;
            lblAddress.Text = "Địa chỉ:";
            // 
            // txtName
            // 
            txtName.Location = new Point(171, 115);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(377, 27);
            txtName.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(171, 175);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(377, 27);
            txtEmail.TabIndex = 4;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(171, 235);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(377, 27);
            txtPhone.TabIndex = 6;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(171, 495);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(377, 92);
            txtAddress.TabIndex = 14;
            // 
            // dtpBirth
            // 
            dtpBirth.CustomFormat = "dd/MM/yyyy";
            dtpBirth.Format = DateTimePickerFormat.Custom;
            dtpBirth.Location = new Point(171, 295);
            dtpBirth.Margin = new Padding(3, 4, 3, 4);
            dtpBirth.Name = "dtpBirth";
            dtpBirth.Size = new Size(205, 27);
            dtpBirth.TabIndex = 8;
            // 
            // groupGender
            // 
            groupGender.Controls.Add(rdoMale);
            groupGender.Controls.Add(rdoFemale);
            groupGender.Location = new Point(171, 336);
            groupGender.Margin = new Padding(3, 4, 3, 4);
            groupGender.Name = "groupGender";
            groupGender.Padding = new Padding(3, 4, 3, 4);
            groupGender.Size = new Size(240, 73);
            groupGender.TabIndex = 10;
            groupGender.TabStop = false;
            // 
            // rdoMale
            // 
            rdoMale.AutoSize = true;
            rdoMale.Location = new Point(23, 29);
            rdoMale.Margin = new Padding(3, 4, 3, 4);
            rdoMale.Name = "rdoMale";
            rdoMale.Size = new Size(62, 24);
            rdoMale.TabIndex = 0;
            rdoMale.Text = "Nam";
            // 
            // rdoFemale
            // 
            rdoFemale.AutoSize = true;
            rdoFemale.Location = new Point(126, 29);
            rdoFemale.Margin = new Padding(3, 4, 3, 4);
            rdoFemale.Name = "rdoFemale";
            rdoFemale.Size = new Size(50, 24);
            rdoFemale.TabIndex = 1;
            rdoFemale.Text = "Nữ";
            // 
            // cboCourse
            // 
            cboCourse.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCourse.Items.AddRange(new object[] { "Lập trình C#", "Lập trình Java", "Lập trình Web", "Cơ sở dữ liệu", "Điện toán đám mây" });
            cboCourse.Location = new Point(171, 435);
            cboCourse.Margin = new Padding(3, 4, 3, 4);
            cboCourse.Name = "cboCourse";
            cboCourse.Size = new Size(377, 28);
            cboCourse.TabIndex = 12;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(120, 633);
            btnRegister.Margin = new Padding(3, 4, 3, 4);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(137, 53);
            btnRegister.TabIndex = 15;
            btnRegister.Text = "ĐĂNG KÝ";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(274, 633);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(137, 53);
            btnClear.TabIndex = 16;
            btnClear.Text = "LÀM MỚI";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(429, 633);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(137, 53);
            btnClose.TabIndex = 17;
            btnClose.Text = "ĐÓNG";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 733);
            Controls.Add(lblTitle);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblPhone);
            Controls.Add(txtPhone);
            Controls.Add(lblBirth);
            Controls.Add(dtpBirth);
            Controls.Add(lblGender);
            Controls.Add(groupGender);
            Controls.Add(lblCourse);
            Controls.Add(cboCourse);
            Controls.Add(lblAddress);
            Controls.Add(txtAddress);
            Controls.Add(btnRegister);
            Controls.Add(btnClear);
            Controls.Add(btnClose);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormRegister";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Đăng ký học viên";
            groupGender.ResumeLayout(false);
            groupGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}