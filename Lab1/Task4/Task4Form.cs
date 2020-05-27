using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ProgramingTerm4.Lab1.Task4
{
    public partial class Task4Form : Form
    {
        private readonly IList<Label> labels = new List<Label>();

        public Task4Form()
        {
            InitializeComponent();
            var startPosition = new Point(LabelGenerationButton.Location.X, LabelGenerationButton.Location.Y);
            var newLabel = new Label();
            newLabel.Location = startPosition;
            labels.Add(newLabel);
        }

        private void LabelGenerationButton_Click(object sender, EventArgs e)
        {
            var label = new Label();
            label.Text = "label" + labels.Count;
            label.Location = new Point(labels[labels.Count].Location.X, labels[labels.Count].Location.Y + 30);
            var italicBoldFontStyle = FontStyle.Italic;
            italicBoldFontStyle    |= FontStyle.Bold;
            label.Font = new Font("Arial", 10, italicBoldFontStyle);
            this.labels.Add(label);
            this.Controls.Add(label);
        }
    }
}
