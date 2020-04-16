using System;
using System.Windows.Forms;

namespace Lab3.Exercise5
{
    public partial class WinContainer : Form
    {
        public WinContainer()
        {
            InitializeComponent();
        }

        private void But_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                but.Text = "First";
            }
            else if (radioButton2.Checked)
            {
                but.Text = "Second";
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.SetFlowBreak(button6, true);
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            var aButton = new Button();
            tableLayoutPanel1.Controls.Add(aButton, 1, 1);
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            splitContainer1.FixedPanel = (splitContainer1.FixedPanel == FixedPanel.Panel1)
                ? FixedPanel.None
                : FixedPanel.Panel1;
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            splitContainer1.IsSplitterFixed = !splitContainer1.IsSplitterFixed;
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel1Collapsed = !splitContainer1.Panel1Collapsed;
        }
    }
}
