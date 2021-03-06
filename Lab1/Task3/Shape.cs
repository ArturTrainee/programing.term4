﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProgramingTerm4.Lab1.Task3
{
    internal class Shape
    {
        private static readonly Color defaultColor = Color.Green;

        private readonly Panel panel;

        public Color ColorOnHover { get; set; }

        public Shape(Panel panel)
        {
            if (panel == null) throw new ArgumentNullException("Panel is null");
            this.panel = panel;
            ColorOnHover = defaultColor;
        }

        public void ChangeColorOnHover()
        {
            panel.BackColor = ColorOnHover;
        }

        public void ChangeColorToDefault()
        {
            panel.BackColor = defaultColor;
        }
    }
}
