using System;
using System.Collections.Generic;
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
            var labelsList = new List<Control>();

            foreach (Control control in Controls)
            {
                if (control is Label)
                {
                    labelsList.Add(control);
                }
            }

            foreach (var label in labelsList)
            {
                Controls.Remove(label);
                label.Dispose();
            }
        }
    }
}