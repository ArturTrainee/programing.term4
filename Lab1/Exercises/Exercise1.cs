using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProgramingTerm4.Lab1.Exercises
{
    public partial class Exercise1 : Form
    {
        public Exercise1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Size = new Size(300, 500);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Opacity = 1;
        }
    }
}