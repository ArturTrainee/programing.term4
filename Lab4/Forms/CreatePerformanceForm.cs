using System;
using System.Windows.Forms;
using Lab4.Entities;

namespace Lab4.Forms
{
    public partial class CreatePerformanceForm : Form
    {
        private static readonly Enum[] CATEGORIES = new Enum[] {
            Category.Drama, Category.Operata, Category.Opera, Category.Ballet
        };

        private Performance performance;

        internal Performance Performance { get => performance; }

        public CreatePerformanceForm()
        {
            InitializeComponent();

            comboBox1.Items.AddRange(CATEGORIES);
            comboBox1.SelectedItem = CATEGORIES[0];

            dateTimePicker1.Value = DateTime.Now;

            performance = new Performance();
        }

        private void AddLocationBtn_Click(object sender, EventArgs e)
        {
            var createLocationForm = new CreateLocationForm();

            try
            {
                if (createLocationForm.ShowDialog() == DialogResult.OK)
                {
                    performance.Location = createLocationForm.CreatedLocation;
                    textBox2.Text = performance.Location.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddTroupe_Click(object sender, EventArgs e)
        {
            var createTroupeForm = new CreateTroupeForm();

            try
            {
                if (createTroupeForm.ShowDialog() == DialogResult.OK)
                {
                    performance.Troupe = createTroupeForm.Troupe;
                    textBox3.Text = performance.Troupe.ToString();
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
                performance.Name = textBox1.Text;
                performance.Category = (Category)Enum.Parse(typeof(Category), comboBox1.SelectedItem.ToString());
                performance.StartDate = dateTimePicker1.Value;
                performance.RentPrice = int.Parse(textBox4.Text);
                performance.HasOrchestra = checkBox1.Checked;
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            performance.Category = (Category)CATEGORIES[comboBox1.SelectedIndex];
        }
    }
}
