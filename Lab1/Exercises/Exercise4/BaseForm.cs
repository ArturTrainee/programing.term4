using System;
using System.Windows.Forms;

namespace ProgramingTerm4.Lab1.Exercises
{
    public partial class Exercise4BaseForm : Form
    {
        private int openedDocuments;

        public Exercise4BaseForm()
        {
            InitializeComponent();
        }

        private void FileExitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void WindowCascadeMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void WindowTileMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void NewMenuItem_Click(object sender, EventArgs e)
        {
            var newChild = new Exercise4ChildForm
            {
                MdiParent = this
            };
            newChild.Text = $"{newChild.Text}{++openedDocuments}";
            newChild.Show();
        }
    }
}