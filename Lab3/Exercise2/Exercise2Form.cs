using System;
using System.Windows.Forms;

namespace Lab3.Exercise2
{
    public partial class TestListForm : Form
    {
        public TestListForm()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (peopleLіst.Text.Length != 0)
            {
                memberLіst.Items.Add(peopleLіst.Text);
            }
            else
            {
                MessageBox.Show("Bиберіть елемент зі списку або введіть новий");
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            while (memberLіst.CheckedIndices.Count > 0)
            {
                memberLіst.Items.RemoveAt(memberLіst.CheckedIndices[0]);
            }
        }

        private void Sort_Click(object sender, EventArgs e) => memberLіst.Sorted = true;
    }
}