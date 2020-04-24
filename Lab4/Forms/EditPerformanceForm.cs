using System;
using System.Windows.Forms;
using Lab4.Entities;

namespace Lab4.Forms
{
    public partial class EditPerformanceForm : Form
    {
        private static readonly Enum[] CATEGORIES = new Enum[] {
            Category.Drama, Category.Operata, Category.Opera, Category.Ballet
        };

        private Performance performance;

        internal Performance Performance { get => performance; }

        internal EditPerformanceForm(Performance performance)
        {
            InitializeComponent();

            nameTextBox.Text = performance.Name;

            comboBox1.Items.AddRange(CATEGORIES);
            comboBox1.SelectedItem = performance.Category;

            locationTextBox.Text = performance.Location.ToString();
            troupeTextBox.Text = performance.Troupe.ToString();
            dateTimePicker1.Value = performance.StartDate;
            rentTextBox.Text = performance.RentPrice.ToString();

            this.performance = performance;
        }

        private void EditLocationBtn_Click(object sender, EventArgs e)
        {
            var editLocationForm = new EditLocationForm(performance.Location);

            try
            {
                if (editLocationForm.ShowDialog() == DialogResult.OK)
                {
                    performance.Location = editLocationForm.EditedLocation;
                    locationTextBox.Text = performance.Location.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            try
            {
                performance.Name = nameTextBox.Text;
                performance.Category = (Category)comboBox1.SelectedItem;
                performance.StartDate = dateTimePicker1.Value;
                performance.RentPrice = int.Parse(rentTextBox.Text);

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
    }
}
