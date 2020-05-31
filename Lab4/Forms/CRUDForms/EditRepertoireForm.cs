using Lab4.Entities;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Lab4.Forms
{
    public partial class RepertoireInfoForm : Form
    {
        private Repertoire repertoire;

        public Repertoire Repertoire
        {
            get
            {
                return repertoire;
            }
        }

        public RepertoireInfoForm() : this(new Repertoire())
        {
        }

        public RepertoireInfoForm(Repertoire repertoireToEdit)
        {
            InitializeComponent();
            repertoire = repertoireToEdit;
            textBox1.Text = repertoire.LocationName;
            foreach (var performance in repertoireToEdit.Performances)
            {
                performancesListBox.Items.Add(performance);
            }
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            editSelectedBtn.Enabled = true;
            deleteSelectedBtn.Enabled = true;
        }

        private void AddPerformanceBtn_Click(object sender, EventArgs e)
        {
            var form = new PerformanceInfoForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                Repertoire.Performances.Add(form.Performance);
                performancesListBox.Items.Add(form.Performance);
            }
        }

        private void EditSelectedBtn_Click(object sender, EventArgs e)
        {
            var selectedPerformance = repertoire.GetPerformanceByToString(performancesListBox.SelectedItem.ToString());
            var editPerformanceForm = new PerformanceInfoForm(selectedPerformance);
            if (editPerformanceForm.ShowDialog() == DialogResult.OK)
            {
                repertoire.Performances.Remove(selectedPerformance);
                repertoire.Performances.Add(editPerformanceForm.Performance);
                performancesListBox.SelectedItem = editPerformanceForm.Performance;
            }
        }

        private void DeletePerformanceBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete selected performance?", "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var selectedPerformance = performancesListBox.SelectedItem.ToString();
                repertoire.Performances.Remove(repertoire.Performances.Where(p => p.ToString().Equals(selectedPerformance)).First());
                performancesListBox.Items.Remove(performancesListBox.SelectedItem);
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

        private void EditRepertoireForm_FormClosing(object sender, FormClosingEventArgs e)
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
