using System;
using System.Windows.Forms;

namespace Bai4_5
{
    public partial class FormMainMdi : Form
    {
        public FormMainMdi()
        {
            InitializeComponent();
        }

        private void menuRegister_Click(object sender, EventArgs e)
        {
            foreach (Form child in MdiChildren)
            {
                if (child is FormRegister)
                {
                    child.Activate();
                    return;
                }
            }

            FormRegister form = new FormRegister();

            form.MdiParent = this;

            form.Show();
        }

        private void menuCascade_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void menuHorizontal_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void menuVertical_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void menuCloseAll_Click(object sender, EventArgs e)
        {
            foreach (Form child in MdiChildren)
            {
                child.Close();
            }
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}