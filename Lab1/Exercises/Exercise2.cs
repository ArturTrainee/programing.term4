using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ProgramingTerm4.Lab1.Exercises
{
    public partial class Exercise2 : Form
    {
        public Exercise2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            var myPath = new GraphicsPath();
            myPath.AddPolygon(new Point[] { new Point(0, 0), new Point(0, Height), new Point(Width, 0) });
            Region = new Region(myPath);
        }
    }
}