using Lab4.Entities;
using System;
using System.Windows.Forms;

namespace Lab4.Forms
{
    public partial class CreateTroupeForm : Form
    {
        private Troupe troupe;

        internal Troupe Troupe
        {
            get
            {
                return troupe;
            }
        }

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
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void CreateTroupeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.OK && MessageBox.Show("Close the window?", "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show(Messages.CHANGES_CANCELED);
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
