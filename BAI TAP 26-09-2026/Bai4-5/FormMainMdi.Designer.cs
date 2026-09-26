using System.Drawing;
using System.Windows.Forms;

namespace Bai4_5
{
    partial class FormMainMdi
    {
        private System.ComponentModel.IContainer components = null;

        private MenuStrip menuStrip1;

        private ToolStripMenuItem menuStudent;
        private ToolStripMenuItem menuRegister;

        private ToolStripMenuItem menuWindow;
        private ToolStripMenuItem menuCascade;
        private ToolStripMenuItem menuHorizontal;
        private ToolStripMenuItem menuVertical;
        private ToolStripMenuItem menuCloseAll;

        private ToolStripMenuItem menuExit;

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
            menuStrip1 = new MenuStrip();

            menuStudent = new ToolStripMenuItem();
            menuRegister = new ToolStripMenuItem();

            menuWindow = new ToolStripMenuItem();

            menuCascade = new ToolStripMenuItem();
            menuHorizontal = new ToolStripMenuItem();
            menuVertical = new ToolStripMenuItem();
            menuCloseAll = new ToolStripMenuItem();

            menuExit = new ToolStripMenuItem();

            menuStrip1.SuspendLayout();

            SuspendLayout();

            // menuStrip1
            menuStrip1.Items.AddRange(
                new ToolStripItem[]
                {
                    menuStudent,
                    menuWindow,
                    menuExit
                }
            );

            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1000, 24);

            // Học viên
            menuStudent.DropDownItems.AddRange(
                new ToolStripItem[]
                {
                    menuRegister
                }
            );

            menuStudent.Name = "menuStudent";
            menuStudent.Text = "Học viên";

            // Đăng ký học viên
            menuRegister.Name = "menuRegister";
            menuRegister.Text = "Đăng ký học viên";
            menuRegister.Click += menuRegister_Click;

            // Cửa sổ
            menuWindow.DropDownItems.AddRange(
                new ToolStripItem[]
                {
                    menuCascade,
                    menuHorizontal,
                    menuVertical,
                    menuCloseAll
                }
            );

            menuWindow.Name = "menuWindow";
            menuWindow.Text = "Cửa sổ";

            // Xếp tầng
            menuCascade.Name = "menuCascade";
            menuCascade.Text = "Xếp tầng";
            menuCascade.Click += menuCascade_Click;

            // Xếp ngang
            menuHorizontal.Name = "menuHorizontal";
            menuHorizontal.Text = "Xếp ngang";
            menuHorizontal.Click += menuHorizontal_Click;

            // Xếp dọc
            menuVertical.Name = "menuVertical";
            menuVertical.Text = "Xếp dọc";
            menuVertical.Click += menuVertical_Click;

            // Đóng tất cả
            menuCloseAll.Name = "menuCloseAll";
            menuCloseAll.Text = "Đóng tất cả";
            menuCloseAll.Click += menuCloseAll_Click;

            // Thoát
            menuExit.Name = "menuExit";
            menuExit.Text = "Thoát";
            menuExit.Click += menuExit_Click;

            // FormMainMdi
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;

            ClientSize = new Size(1000, 650);

            Controls.Add(menuStrip1);

            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;

            Name = "FormMainMdi";

            StartPosition = FormStartPosition.CenterScreen;

            Text = "Bài 4.5 - Main Shell MDI";

            WindowState = FormWindowState.Maximized;

            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();

            ResumeLayout(false);
            PerformLayout();
        }
    }
}