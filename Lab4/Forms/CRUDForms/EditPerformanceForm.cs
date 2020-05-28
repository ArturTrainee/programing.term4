using System;
using System.Windows.Forms;
using Lab4.Entities;

namespace Lab4.Forms
{
    public partial class PerformanceInfoForm : Form
    {
        private Performance performance;

        internal Performance Performance
        {
            get => performance;
        }

        public PerformanceInfoForm() : this(new Performance())
        {
        }

        internal PerformanceInfoForm(Performance performance)
        {
            InitializeComponent();
            this.performance = performance;
            nameTextBox.Text = performance.Name;
            FillCategoryComboBox();
            locationTextBox.Text = performance.Location.ToString();
            troupeTextBox.Text = performance.Troupe.ToString();
            dateTimePicker1.Value = performance.StartDate;
            rentTextBox.Text = performance.RentPrice.ToString();
        }
    
        private void FillCategoryComboBox()
        {
            var categories = (Category[])Enum.GetValues(typeof(Category));
            foreach (var c in categories)
            {
                categoryComboBox.Items.Add(c);
            }
            categoryComboBox.SelectedIndex = (int)performance.Category;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            performance.Category = (Category)categoryComboBox.SelectedIndex;
        }

        private void EditLocationBtn_Click(object sender, EventArgs e)
        {
            var editLocationForm = new LocationInfoForm(performance.Location);
            try
            {
                if (editLocationForm.ShowDialog() == DialogResult.OK)
                {
                    performance.Location = editLocationForm.NewLocation;
                    locationTextBox.Text = performance.Location.ToString();
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditTroupeBtn_Click(object sender, EventArgs e)
        {
            var editTroupeForm = new TroupeInfoForm(Performance.Troupe);
            if (editTroupeForm.ShowDialog() == DialogResult.OK)
            {
                performance.Troupe = editTroupeForm.Troupe;
                troupeTextBox.Text = performance.Troupe.ToString();
            }
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            try
            {
                performance.Name = nameTextBox.Text;
                performance.Category = (Category)categoryComboBox.SelectedIndex;
                performance.StartDate = dateTimePicker1.Value;
                performance.RentPrice = int.Parse(rentTextBox.Text);
                performance.HasOrchestra = withOrchestraCheckBox.Checked;
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

        private void EditPerformanceForm_FormClosing(object sender, FormClosingEventArgs e)
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
