using Lab4.Entities;
using System;
using System.Windows.Forms;

namespace Lab4.Forms
{
    public partial class CreateTroupeForm : Form
    {
        private Troupe troupe;

        internal Troupe Troupe { get => troupe; }

        public CreateTroupeForm()
        {
            InitializeComponent();
            troupe = new Troupe();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            try
            {
                troupe.Name = textBox1.Text;
                troupe.ActorsAmount = int.Parse(textBox2.Text);
                troupe.ActorsSalary = int.Parse(textBox3.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DialogResult = DialogResult.OK;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
