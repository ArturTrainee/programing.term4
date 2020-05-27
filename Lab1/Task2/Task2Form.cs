using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProgramingTerm4.Lab1.Task2
{
    public partial class Task2Form : Form
    {
        public Task2Form()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Controls.OfType<Label>().ToList().ForEach(l => l.Dispose());
        }
    }
}