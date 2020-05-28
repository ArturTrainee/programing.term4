using Lab4.Entities;
using Lab4.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace Lab4.Forms
{
    public partial class MainForm : Form
    {
        private static readonly string REPERTOIRES_PATH = Path.Combine(Directory.GetCurrentDirectory(), "all_repertoires.xml");

        private readonly IDictionary<string, Repertoire> repertoires = new Dictionary<string, Repertoire>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var repertoiresList = XmlRepertoiresReader.ReadEntitiesFrom(REPERTOIRES_PATH);
            foreach (var repertoire in repertoiresList)
            {
                repertoires.Add(repertoire.ToShortString(), repertoire);
                repertoiresListBox.Items.Add(repertoire.ToShortString());
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var writeSettings = new XmlWriterSettings();
            writeSettings.Indent = true;
            writeSettings.NewLineOnAttributes = true;
            writeSettings.OmitXmlDeclaration = false;
            writeSettings.ConformanceLevel = ConformanceLevel.Auto;
            XmlRepertoiresWriter.WriteEntitiesTo(REPERTOIRES_PATH, writeSettings, repertoires.Values.ToList());
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (repertoiresListBox.SelectedIndex == -1)
            {
                buttonEditSelected.Enabled = false;
                deleteBtn.Enabled = false;
            }
            else 
            {
                buttonEditSelected.Enabled = true;
                deleteBtn.Enabled = true;
            }
        }

        private void ButtonNew_Click(object sender, EventArgs e)
        {
            var formCreateRepertoire = new RepertoireInfoForm();
            if (formCreateRepertoire.ShowDialog() == DialogResult.OK)
            {
                var newRepertoire = formCreateRepertoire.Repertoire;
                repertoiresListBox.Items.Add(newRepertoire.ToShortString());
                repertoires.Add(newRepertoire.ToShortString(), newRepertoire);
            }
        }

        private void ButtonEditSelected_Click(object sender, EventArgs e)
        {
            if (repertoiresListBox.SelectedIndices.Count > 1)
            {
                MessageBox.Show("Виберіть рівно один репертуар");
                return;
            }
            var selectedItem = repertoiresListBox.SelectedItem;
            var id = selectedItem.ToString();
            repertoires.TryGetValue(id, out Repertoire selectedRepertoire);
            var formEditRepertoire = new RepertoireInfoForm(selectedRepertoire);
            if (formEditRepertoire.ShowDialog() == DialogResult.OK)
            {
                var editedRepertoire = formEditRepertoire.Repertoire;
                repertoires.Remove(id);
                repertoiresListBox.Items.Remove(id);
                repertoires.Add(editedRepertoire.ToShortString(), editedRepertoire);
                repertoiresListBox.Items.Add(editedRepertoire.ToShortString());
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (repertoiresListBox.SelectedIndices.Count > 1)
            {
                MessageBox.Show("Виберіть рівно один репертуар");
                return;
            }
            if (MessageBox.Show("Delete selected repertoire?", "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {   
                var selectedItem = repertoiresListBox.SelectedItem;
                repertoires.Remove(selectedItem.ToString());
                repertoiresListBox.Items.RemoveAt(repertoiresListBox.SelectedIndex);
            }
        }
    }
}
