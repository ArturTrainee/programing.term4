using System;
using System.Windows.Forms;

namespace ProgramingTerm4.Lab1.Task1
{
    public partial class Task1Form : Form
    {
        public Task1Form() => InitializeComponent();

        private void Button1_Click(object sender, EventArgs e) => Close();

        private void Button2_Click(object sender, EventArgs e) => new Task1Form2().Show();
    }
}