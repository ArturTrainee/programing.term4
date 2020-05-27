using System;
using System.Windows.Forms;

namespace Lab3.Exercise1
{
    public partial class WіnQuestіonForm : Form
    {
        public WіnQuestіonForm()
        {
            InitializeComponent();
        }

        private void Btnyes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mи й не сумнівалися, що Ви так думаєте!");
        }

        private void Btnno_MouseMove(object sender, MouseEventArgs e)
        {
            btnno.Top -= e.Y;
            btnno.Left += e.X;

            if (btnno.Top < -10 || btnno.Top > 100)
            {
                btnno.Top = 60;
            }
            if (btnno.Left < -80 || btnno.Left > 250)
            {
                btnno.Left = 120;
            }
        }

        private void btnno_Enter(object sender, EventArgs e)
        {
            btnyes.Focus();
        }
    }
}