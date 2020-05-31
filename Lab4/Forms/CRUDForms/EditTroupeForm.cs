using Lab4.Entities;
using System;
using System.Windows.Forms;

namespace Lab4.Forms
{
    public partial class TroupeInfoForm : Form
    {
        private Troupe troupe;

        internal Troupe Troupe
        {
            get
            {
                return troupe;
            }
        }

        public TroupeInfoForm() : this(new Troupe())
        {
        }

        public TroupeInfoForm(Troupe troupe)
        {
            InitializeComponent();
            this.troupe = troupe;
            nameTextBox.Text = troupe.Name;
            actorsAmountTextBox.Text = troupe.ActorsAmount.ToString();
            actorsSalaryTextBox.Text = troupe.ActorsSalary.ToString();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            try
            {
                troupe.Name = nameTextBox.Text;
                troupe.ActorsAmount = int.Parse(actorsAmountTextBox.Text);
                troupe.ActorsSalary = int.Parse(actorsSalaryTextBox.Text);
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

        private void EditTroupeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.OK)
            {
                if (MessageBox.Show("Close the window?", "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MessageBox.Show(Messages.CHANGES_CANCELED);
                }
                else e.Cancel = true;
            }
        }
    }
}
