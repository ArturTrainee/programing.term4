using Lab4.Entities;
using Lab4.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Lab4.Forms
{
    public partial class MainForm : Form
    {
        internal static readonly string REPERTOIRES_PATH = Path.Combine(Directory.GetCurrentDirectory(), "all_repertoires.xml");

        private IList<Repertoire> repertoires;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            repertoires = XmlEntitiesReader<Repertoire>.ReadEntitiesFrom(REPERTOIRES_PATH, "Repertoire", "ArrayOfRepertoire");
            foreach (var repertoire in repertoires)
            {
                listBox1.Items.Add(repertoire.ToShortString());
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            XmlFileWriter<Repertoire>.WriteEntitiesTo(REPERTOIRES_PATH, repertoires);
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonEditSelected.Enabled = true;
        }

        private void ButtonNew_Click(object sender, EventArgs e)
        {
            var formCreateRepertoire = new CreateRepertoireForm();
            if (formCreateRepertoire.ShowDialog() == DialogResult.OK)
            {
                var newRepertoire = formCreateRepertoire.Repertoire;
                listBox1.Items.Add(newRepertoire.ToString());
                repertoires.Add(newRepertoire);
            }
        }

        private void ButtonEditSelected_Click(object sender, EventArgs e)
        {
            var idx = listBox1.SelectedIndex;
            if (idx < 0 || idx >= repertoires.Count)
            {
                MessageBox.Show("Виберіть рівно один репертуар");
                return;
            }
            var formEditRepertoire = new EditRepertoireForm(repertoires[listBox1.SelectedIndex]);
            if (formEditRepertoire.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items[idx] = repertoires[listBox1.SelectedIndex].ToString();
            }
        }
    }
}
