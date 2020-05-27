using Lab4.Entities;
using System;
using System.Windows.Forms;

namespace Lab4.Forms
{
    public partial class EditRepertoireForm : Form
    {
        private Repertoire repertoire;

        public EditRepertoireForm(Repertoire repertoireToEdit)
        {
            InitializeComponent();
            repertoire = repertoireToEdit;
            textBox1.Text = repertoire.LocationName;
            foreach (var performance in repertoireToEdit.Performances)
            {
                listBox1.Items.Add(performance);
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
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void EditSelectedBtn_Click(object sender, EventArgs e)
        {
            var editPerformanceForm = new EditPerformanceForm(repertoire.Performances[listBox1.SelectedIndex]);
            if (editPerformanceForm.ShowDialog() == DialogResult.OK)
            {
                repertoire.Performances[listBox1.SelectedIndex] = editPerformanceForm.Performance;
            }
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            editSelectedBtn.Enabled = true;
        }

        private void EditRepertoireForm_FormClosing(object sender, FormClosingEventArgs e)
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
