using System.Windows.Forms;

namespace Lab3.Exercise6And7
{
    public partial class WinLinkLabel : Form
    {
        public WinLinkLabel()
        {
            InitializeComponent();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult aResult;
            var aForm = new Form2();
            aResult = aForm.ShowDialog();

            if (aResult == DialogResult.OK)
            {
                MessageBox.Show($"Your name is {aForm.textBox1.Text} {aForm.textBox2.Text}");
                MessageBox.Show($"Your address is {aForm.textBox3.Text}");
                MessageBox.Show($"Your phone number is {aForm.maskedTextBox1.Text}");
                linkLabel1.LinkVisited = true;
            }
        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.google.com");
            linkLabel2.LinkVisited = true;
        }
    }
}
