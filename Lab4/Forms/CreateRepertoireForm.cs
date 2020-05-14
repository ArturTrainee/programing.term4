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
            CreatePerformanceForm formCreatPerformance = new CreatePerformanceForm();

            if (formCreatPerformance.ShowDialog() == DialogResult.OK)
            {
                Performance newPerformance = formCreatPerformance.Performance;
                listBox1.Items.Add(newPerformance.ToString());
                repertoire.Performances.Add(newPerformance);
            }
            else
            {
                MessageBox.Show("Canceled");
            }
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            repertoire.LocationName = textBox1.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
