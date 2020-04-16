using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        private readonly IDictionary<string, EventHandler> options = new Dictionary<string, EventHandler>();

        public Form1()
        {
            InitializeComponent();

            options.Add("chageOpacity", (arg, ev) => Opacity = (Opacity == 1) ? 0.5 : 1);
            options.Add("changeBgColor", (arg, ev) => BackColor = (BackColor == Color.Gray) ? Color.Yellow : Color.Gray);
            options.Add("showHelloWorld", (arg, ev) => MessageBox.Show("Hello World"));
        }

        private void OpacityButton_Click(object sender, EventArgs e)
        {
            options.TryGetValue("chageOpacity", out EventHandler handler);
            handler.Invoke(sender, e);
        }

        private void BgColorButton_Click(object sender, EventArgs e)
        {
            options.TryGetValue("changeBgColor", out EventHandler handler);
            handler.Invoke(sender, e);
        }

        private void HelloWorldButton_Click(object sender, EventArgs e)
        {
            options.TryGetValue("showHelloWorld", out EventHandler handler);
            handler.Invoke(sender, e);
        }

        private void OpacityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            options.TryGetValue("chageOpacity", out EventHandler handler);
            OnSuperButtonCheckBox_CheckedChanged(opacityCheckBox, handler);
        }

        private void BgColorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            options.TryGetValue("changeBgColor", out EventHandler handler);
            OnSuperButtonCheckBox_CheckedChanged(bgColorCheckBox, handler);
        }

        private void HelloWorldCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            options.TryGetValue("showHelloWorld", out EventHandler handler);
            OnSuperButtonCheckBox_CheckedChanged(helloWorldCheckBox, handler);
        }

        private void SuperButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I am super button!");
        }

        private void OnSuperButtonCheckBox_CheckedChanged(CheckBox checkBox, EventHandler eventHandler)
        {
            if (checkBox.Checked)
            {
                superButton.Click += eventHandler;
            }
            else
            {
                superButton.Click -= eventHandler;
            }
        }
    }
}