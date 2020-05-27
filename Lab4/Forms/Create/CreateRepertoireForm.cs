using Lab4.Entities;
using System;
using System.Windows.Forms;

namespace Lab4.Forms
{
    public partial class CreateRepertoireForm : Form
    {
        private Repertoire repertoire;

        public CreateRepertoireForm()
        {
            InitializeComponent();
            repertoire = new Repertoire();
        }

        public Repertoire Repertoire
        {
            get
            {
                return repertoire;
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            var formCreatPerformance = new CreatePerformanceForm();
            if (formCreatPerformance.ShowDialog() == DialogResult.OK)
            {
                var newPerformance = formCreatPerformance.Performance;
                listBox1.Items.Add(newPerformance.ToString());
                repertoire.Performances.Add(newPerformance);
            }
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            try
            {
                repertoire.LocationName = textBox1.Text;
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void CreateRepertoireForm_FormClosing(object sender, FormClosingEventArgs e)
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
