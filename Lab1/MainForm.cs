using ProgramingTerm4.Lab1.Exercises;
using ProgramingTerm4.Lab1.Task1;
using ProgramingTerm4.Lab1.Task2;
using ProgramingTerm4.Lab1.Task3;
using ProgramingTerm4.Lab1.Task4;
using System;
using System.Windows.Forms;

namespace ProgramingTerm4
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Exercise1().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Exercise2().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Exercise3().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Exercise4BaseForm().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Task1Form().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Task2Form().Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new Task3Form().Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new Task4Form().Show();
        }
    }
}
