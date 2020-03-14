using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProgramingTerm4.Lab1.Task3
{
    public partial class Task3Form : Form
    {
        private readonly Shape shape;

        public Task3Form()
        {
            InitializeComponent();
            shape = new Shape(panel1);
        }

        private void OnMouseMove(object sender, EventArgs e)
        {
            panel1.MouseHover += (obj, ev) => shape.ChangeColorOnHover();
            panel1.MouseLeave += (obj, ev) => shape.ChangeColorToDefault();
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox1.Text)
            {
                case "Blue":   shape.ColorOnHover = Color.Blue; break;
                case "Black":  shape.ColorOnHover = Color.Black; break;
                case "Yellow": shape.ColorOnHover = Color.Yellow; break;
            }
        }
    }
}