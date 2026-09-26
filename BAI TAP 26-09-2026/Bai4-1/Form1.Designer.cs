using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
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
            txtDisplay = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();

            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnDivide = new Button();

            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnMultiply = new Button();

            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnMinus = new Button();

            btnClear = new Button();
            btn0 = new Button();
            btnEqual = new Button();
            btnPlus = new Button();

            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();

            // lblTitle
            lblTitle.Anchor = AnchorStyles.Top;
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font(
                "Segoe UI",
                16F,
                FontStyle.Bold
            );
            lblTitle.Location = new Point(118, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(148, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "CALCULATOR";

            // txtDisplay
            txtDisplay.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Left |
                AnchorStyles.Right;

            txtDisplay.Font = new System.Drawing.Font(
                "Segoe UI",
                20F,
                FontStyle.Regular
            );

            txtDisplay.Location = new Point(25, 65);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(330, 43);
            txtDisplay.TabIndex = 1;
            txtDisplay.Text = "0";
            txtDisplay.TextAlign = HorizontalAlignment.Right;

            // tableLayoutPanel1
            tableLayoutPanel1.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Bottom |
                AnchorStyles.Left |
                AnchorStyles.Right;

            tableLayoutPanel1.ColumnCount = 4;

            tableLayoutPanel1.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 25F));

            tableLayoutPanel1.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 25F));

            tableLayoutPanel1.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 25F));

            tableLayoutPanel1.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 25F));

            tableLayoutPanel1.RowCount = 4;

            tableLayoutPanel1.RowStyles.Add(
                new RowStyle(SizeType.Percent, 25F));

            tableLayoutPanel1.RowStyles.Add(
                new RowStyle(SizeType.Percent, 25F));

            tableLayoutPanel1.RowStyles.Add(
                new RowStyle(SizeType.Percent, 25F));

            tableLayoutPanel1.RowStyles.Add(
                new RowStyle(SizeType.Percent, 25F));

            tableLayoutPanel1.Location = new Point(25, 125);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Size = new Size(330, 300);
            tableLayoutPanel1.TabIndex = 2;

            // btn7
            btn7.Dock = DockStyle.Fill;
            btn7.Font = new System.Drawing.Font(
                "Segoe UI",
                14F,
                FontStyle.Bold
            );
            btn7.Margin = new Padding(5);
            btn7.Name = "btn7";
            btn7.TabIndex = 0;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btnNum_Click;

            // btn8
            btn8.Dock = DockStyle.Fill;
            btn8.Font = new System.Drawing.Font(
                "Segoe UI",
                14F,
                FontStyle.Bold
            );
            btn8.Margin = new Padding(5);
            btn8.Name = "btn8";
            btn8.TabIndex = 1;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btnNum_Click;

            // btn9
            btn9.Dock = DockStyle.Fill;
            btn9.Font = new System.Drawing.Font(
                "Segoe UI",
                14F,
                FontStyle.Bold
            );
            btn9.Margin = new Padding(5);
            btn9.Name = "btn9";
            btn9.TabIndex = 2;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btnNum_Click;

            // btnDivide
            btnDivide.Dock = DockStyle.Fill;
            btnDivide.Font = new System.Drawing.Font(
                "Segoe UI",
                14F,
                FontStyle.Bold
            );
            btnDivide.Margin = new Padding(5);
            btnDivide.Name = "btnDivide";
            btnDivide.TabIndex = 3;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnOperator_Click;

            // btn4
            btn4.Dock = DockStyle.Fill;
            btn4.Font = new System.Drawing.Font(
                "Segoe UI",
                14F,
                FontStyle.Bold
            );
            btn4.Margin = new Padding(5);
            btn4.Name = "btn4";
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btnNum_Click;

            // btn5
            btn5.Dock = DockStyle.Fill;
            btn5.Font = new System.Drawing.Font(
                "Segoe UI",
                14F,
                FontStyle.Bold
            );
            btn5.Margin = new Padding(5);
            btn5.Name = "btn5";
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btnNum_Click;

            // btn6
            btn6.Dock = DockStyle.Fill;
            btn6.Font = new System.Drawing.Font(
                "Segoe UI",
                14F,
                FontStyle.Bold
            );
            btn6.Margin = new Padding(5);
            btn6.Name = "btn6";
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btnNum_Click;

            // btnMultiply
            btnMultiply.Dock = DockStyle.Fill;
            btnMultiply.Font = new System.Drawing.Font(
                "Segoe UI",
                14F,
                FontStyle.Bold
            );
            btnMultiply.Margin = new Padding(5);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.TabIndex = 7;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnOperator_Click;

            // btn1
            btn1.Dock = DockStyle.Fill;
            btn1.Font = new System.Drawing.Font(
                "Segoe UI",
                14F,
                FontStyle.Bold
            );
            btn1.Margin = new Padding(5);
            btn1.Name = "btn1";
            btn1.TabIndex = 8;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btnNum_Click;

            // btn2
            btn2.Dock = DockStyle.Fill;
            btn2.Font = new System.Drawing.Font(
                "Segoe UI",
                14F,
                FontStyle.Bold
            );
            btn2.Margin = new Padding(5);
            btn2.Name = "btn2";
            btn2.TabIndex = 9;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btnNum_Click;

            // btn3
            btn3.Dock = DockStyle.Fill;
            btn3.Font = new System.Drawing.Font(
                "Segoe UI",
                14F,
                FontStyle.Bold
            );
            btn3.Margin = new Padding(5);
            btn3.Name = "btn3";
            btn3.TabIndex = 10;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btnNum_Click;

            // btnMinus
            btnMinus.Dock = DockStyle.Fill;
            btnMinus.Font = new System.Drawing.Font(
                "Segoe UI",
                14F,
                FontStyle.Bold
            );
            btnMinus.Margin = new Padding(5);
            btnMinus.Name = "btnMinus";
            btnMinus.TabIndex = 11;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnOperator_Click;

            // btnClear
            btnClear.Dock = DockStyle.Fill;
            btnClear.Font = new System.Drawing.Font(
                "Segoe UI",
                14F,
                FontStyle.Bold
            );
            btnClear.Margin = new Padding(5);
            btnClear.Name = "btnClear";
            btnClear.TabIndex = 12;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;

            // btn0
            btn0.Dock = DockStyle.Fill;
            btn0.Font = new System.Drawing.Font(
                "Segoe UI",
                14F,
                FontStyle.Bold
            );
            btn0.Margin = new Padding(5);
            btn0.Name = "btn0";
            btn0.TabIndex = 13;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btnNum_Click;

            // btnEqual
            btnEqual.Dock = DockStyle.Fill;
            btnEqual.Font = new System.Drawing.Font(
                "Segoe UI",
                14F,
                FontStyle.Bold
            );
            btnEqual.Margin = new Padding(5);
            btnEqual.Name = "btnEqual";
            btnEqual.TabIndex = 14;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;

            // btnPlus
            btnPlus.Dock = DockStyle.Fill;
            btnPlus.Font = new System.Drawing.Font(
                "Segoe UI",
                14F,
                FontStyle.Bold
            );
            btnPlus.Margin = new Padding(5);
            btnPlus.Name = "btnPlus";
            btnPlus.TabIndex = 15;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnOperator_Click;

            // Add controls vào TableLayoutPanel
            tableLayoutPanel1.Controls.Add(btn7, 0, 0);
            tableLayoutPanel1.Controls.Add(btn8, 1, 0);
            tableLayoutPanel1.Controls.Add(btn9, 2, 0);
            tableLayoutPanel1.Controls.Add(btnDivide, 3, 0);

            tableLayoutPanel1.Controls.Add(btn4, 0, 1);
            tableLayoutPanel1.Controls.Add(btn5, 1, 1);
            tableLayoutPanel1.Controls.Add(btn6, 2, 1);
            tableLayoutPanel1.Controls.Add(btnMultiply, 3, 1);

            tableLayoutPanel1.Controls.Add(btn1, 0, 2);
            tableLayoutPanel1.Controls.Add(btn2, 1, 2);
            tableLayoutPanel1.Controls.Add(btn3, 2, 2);
            tableLayoutPanel1.Controls.Add(btnMinus, 3, 2);

            tableLayoutPanel1.Controls.Add(btnClear, 0, 3);
            tableLayoutPanel1.Controls.Add(btn0, 1, 3);
            tableLayoutPanel1.Controls.Add(btnEqual, 2, 3);
            tableLayoutPanel1.Controls.Add(btnPlus, 3, 3);

            // Form1
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;

            ClientSize = new Size(380, 450);

            Controls.Add(lblTitle);
            Controls.Add(txtDisplay);
            Controls.Add(tableLayoutPanel1);

            MinimumSize = new Size(400, 490);

            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 4.1 - Calculator Responsive";

            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox txtDisplay;
        private TableLayoutPanel tableLayoutPanel1;

        private Button btn0;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;

        private Button btnPlus;
        private Button btnMinus;
        private Button btnMultiply;
        private Button btnDivide;

        private Button btnEqual;
        private Button btnClear;
    }
}