using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProgramingTerm4.Lab1.Exercises
{
    public partial class Exercise4ChildForm : Form
    {
        public Exercise4ChildForm()
        {
            InitializeComponent();
        }

        private void ToggleMenuItem_Click(object sender, EventArgs e)
        {
            if (ToggleMenuItem.Checked)
            {
                ToggleMenuItem.Checked = false;
                ChildTextBox.ForeColor = Color.Black;
            }
            else
            {
                ToggleMenuItem.Checked = true;
                ChildTextBox.ForeColor = Color.Blue;
            }
        }
    }
}