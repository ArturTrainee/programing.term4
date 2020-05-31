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
            get
            {
                return performance;
            }
        }

        public PerformanceInfoForm()
        {
            InitializeComponent();
            performance = new Performance();
            FillCategoryComboBox();
            addLocationBtn.Enabled = true;
            addTroupBtn.Enabled = true;
        }

        internal PerformanceInfoForm(Performance performance)
        {
            InitializeComponent();
            this.performance = performance;
            nameTextBox.Text = performance.Name;
            FillCategoryComboBox();
            dateTimePicker1.Value = performance.StartDate;
            rentTextBox.Text = performance.RentPrice.ToString();
            editLocationBtn.Enabled = true;
            editTroupeBtn.Enabled = true;
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


        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            performance.Category = (Category)categoryComboBox.SelectedIndex;
        }

        private void AddLocationBtn_Click(object sender, EventArgs e)
        {
            var editLocationForm = new LocationInfoForm();
            if (editLocationForm.ShowDialog() == DialogResult.OK)
            {
                performance.Location = editLocationForm.NewLocation;
                locationTextBox.Text = performance.Location.ToString();
                addLocationBtn.Enabled = false;
            }
        }

        private void AddTroupBtn_Click(object sender, EventArgs e)
        {
            var editTroupeForm = new TroupeInfoForm();
            if (editTroupeForm.ShowDialog() == DialogResult.OK)
            {
                performance.Troupe = editTroupeForm.Troupe;
                troupeTextBox.Text = performance.Troupe.ToString();
                addTroupBtn.Enabled = false;
            }
        }

        private void EditLocationBtn_Click(object sender, EventArgs e)
        {
            var editLocationForm = new LocationInfoForm(performance.Location);
            if (editLocationForm.ShowDialog() == DialogResult.OK)
            {
                performance.Location = editLocationForm.NewLocation;
                locationTextBox.Text = performance.Location.ToString();
            }
        }

        private void EditTroupeBtn_Click(object sender, EventArgs e)
        {
            var editTroupeForm = new TroupeInfoForm(performance.Troupe);
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
                if (performance.Location is null)
                {
                    MessageBox.Show("Location is not added");
                    return;
                }
                if (performance.Troupe is null)
                {
                    MessageBox.Show("Troup is not added");
                    return;
                }
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
