using Lab4.Entities;
using System;
using System.Windows.Forms;

namespace Lab4.Forms
{
    public partial class EditTroupeForm : Form
    {
        private Troupe troupe;

        internal Troupe Troupe
        {
            get
            {
                return troupe;
            }
        }

        public EditTroupeForm(Troupe troupe)
        {
            InitializeComponent();
            this.troupe = troupe;
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            try
            {
                troupe.Name = nameTextBox.Text;
                troupe.ActorsAmount = int.Parse(actorsAmountTextBox.Text);
                troupe.ActorsSalary = int.Parse(actorsSalaryTextBox.Text);
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
