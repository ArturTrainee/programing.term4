using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ProgramingTerm4.Lab1.Task4
{
    public partial class Task4Form : Form
    {
        private readonly IDictionary<Label, int> labels = new Dictionary<Label, int>();
        private int labelId = 1;

        public Task4Form()
        {
            InitializeComponent();
            var startPosition = new Point(LabelGenerationButton.Location.X, LabelGenerationButton.Location.Y);
            var newLabel = new Label();
            newLabel.Location = startPosition;
            labels.Add(newLabel, labelId);
        }

        private void LabelGenerationButton_Click(object sender, EventArgs e)
        {
            var label = new Label
            {
                Text = "label",
                Location = new Point(labels.Last().Key.Location.X, labels.Last().Key.Location.Y + 30)
            };

            var italicBoldFontStyle = FontStyle.Italic;
            italicBoldFontStyle    |= FontStyle.Bold;
            label.Font = new Font("Arial", 10, italicBoldFontStyle);

            labels.Add(label, labelId);
            
            label.MouseClick += (obj, ev) =>
            {
                labels.TryGetValue(label, out int id);
                new ToolTip().SetToolTip(label, id.ToString());
            };

            labelId++;

            Controls.Add(label);
        }
    }
}
