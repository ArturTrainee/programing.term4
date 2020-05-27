using System;
using System.Windows.Forms;
using Lab4.Entities;

namespace Lab4.Forms
{
    public partial class CreatePerformanceForm : Form
    {
        private Performance performance;

        internal Performance Performance
        {
            get
            {
                return performance;
            }
        }

        public CreatePerformanceForm()
        {
            InitializeComponent();
            performance = new Performance();
            comboBox1.Items.AddRange(new Enum[] { Category.Drama, Category.Operata, Category.Opera, Category.Ballet });
            comboBox1.SelectedItem = Category.Drama;
            dateTimePicker1.Value = DateTime.Now;
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
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            performance.Category = (Category)comboBox1.SelectedIndex;
        }

        private void CreatePerformanceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.OK)
            {
                if (MessageBox.Show("Close the window?", "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
}
