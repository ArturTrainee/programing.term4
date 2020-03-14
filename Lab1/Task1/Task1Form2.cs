using System;
using System.Windows.Forms;

namespace ProgramingTerm4.Lab1.Task1
{
    public partial class Task1Form2 : Form
    {
        public Task1Form2() => InitializeComponent();

        private void Button1_Click(object sender, EventArgs e)
        {
            var f = new Task1Form3();
            f.FormClosed += (obj, closeEvent) => Close();
            f.Show();
        }
    }
}