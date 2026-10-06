
namespace Bai5_4
{
    partial class FrmFileManager
    {
        private System.ComponentModel.IContainer components = null;

        private SplitContainer splitContainer1;
        private TreeView tvDepartments;
        private ListView lvEmployees;
        private ComboBox cboViewMode;
        private Label lblViewMode;
        private Label lblTitle;

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
            splitContainer1 = new SplitContainer();
            tvDepartments = new TreeView();
            lvEmployees = new ListView();
            cboViewMode = new ComboBox();
            lblViewMode = new Label();
            lblTitle = new Label();

            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();

            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.Location = new Point(245, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(310, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "TRÌNH QUẢN LÝ TẬP TIN";

            lblViewMode.AutoSize = true;
            lblViewMode.Location = new Point(575, 32);
            lblViewMode.Name = "lblViewMode";
            lblViewMode.Size = new Size(75, 15);
            lblViewMode.TabIndex = 1;
            lblViewMode.Text = "Chế độ xem:";

            cboViewMode.DropDownStyle = ComboBoxStyle.DropDownList;
            cboViewMode.FormattingEnabled = true;
            cboViewMode.Location = new Point(660, 28);
            cboViewMode.Name = "cboViewMode";
            cboViewMode.Size = new Size(140, 23);
            cboViewMode.TabIndex = 2;
            cboViewMode.SelectedIndexChanged += cboViewMode_SelectedIndexChanged;

            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer1.Location = new Point(20, 70);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Size = new Size(780, 500);
            splitContainer1.SplitterDistance = 250;
            splitContainer1.TabIndex = 3;

            splitContainer1.Panel1.Controls.Add(tvDepartments);
            splitContainer1.Panel2.Controls.Add(lvEmployees);

            tvDepartments.Dock = DockStyle.Fill;
            tvDepartments.Location = new Point(0, 0);
            tvDepartments.Name = "tvDepartments";
            tvDepartments.Size = new Size(250, 500);
            tvDepartments.TabIndex = 0;
            tvDepartments.AfterSelect += tvDepartments_AfterSelect;

            lvEmployees.Columns.Add("Mã NV", 90);
            lvEmployees.Columns.Add("Họ Tên", 180);
            lvEmployees.Columns.Add("Chức vụ", 160);
            lvEmployees.Columns.Add("Ngày vào làm", 120);
            lvEmployees.Dock = DockStyle.Fill;
            lvEmployees.FullRowSelect = true;
            lvEmployees.GridLines = true;
            lvEmployees.Location = new Point(0, 0);
            lvEmployees.Name = "lvEmployees";
            lvEmployees.Size = new Size(526, 500);
            lvEmployees.TabIndex = 0;
            lvEmployees.UseCompatibleStateImageBehavior = false;
            lvEmployees.View = View.Details;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 595);
            Controls.Add(splitContainer1);
            Controls.Add(cboViewMode);
            Controls.Add(lblViewMode);
            Controls.Add(lblTitle);
            MinimumSize = new Size(700, 500);
            Name = "FrmFileManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 5.4 - TreeView & ListView";

            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
