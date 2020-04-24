using System;
using System.Windows.Forms;
using Lab4.Entities;

namespace Lab4.Forms
{
    public partial class CreateLocationForm : Form
    {
        private Location location;

        internal Location CreatedLocation { get => location; }

        public CreateLocationForm()
        {
            InitializeComponent();
            location = new Location();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            try
            {
                location.Name = textBox1.Text;
                location.Address = textBox2.Text;
                location.RentalPrice = int.Parse(textBox3.Text);
                location.FreeSeatsAmount = int.Parse(textBox4.Text);
                Entities.Location.orchestraPrice = int.Parse(textBox5.Text);

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
