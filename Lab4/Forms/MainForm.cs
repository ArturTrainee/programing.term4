using Lab4.Entities;
using Lab4.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Lab4.Forms
{
    public partial class MainForm : Form
    {
        internal static readonly string REPERTOIRES_PATH = Path.Combine(Directory.GetCurrentDirectory(), "all_repertoires.xml");

        private readonly IDictionary<string, Repertoire> repertoires = new Dictionary<string, Repertoire>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var repertoiresList = XmlEntitiesReader<Repertoire>.ReadEntitiesFrom(REPERTOIRES_PATH, "Repertoire", "ArrayOfRepertoire");
            foreach (var repertoire in repertoiresList)
            {
                repertoires.Add(repertoire.ToShortString(), repertoire);
                repertoiresListBox.Items.Add(repertoire);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            XmlFileWriter<Repertoire>.WriteEntitiesTo(REPERTOIRES_PATH, repertoires.Values.ToList());
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonEditSelected.Enabled = true;
            deleteBtn.Enabled = true;
        }

        private void ButtonNew_Click(object sender, EventArgs e)
        {
            var formCreateRepertoire = new CreateRepertoireForm();
            if (formCreateRepertoire.ShowDialog() == DialogResult.OK)
            {
                var newRepertoire = formCreateRepertoire.Repertoire;
                repertoiresListBox.Items.Add(newRepertoire.ToString());
                repertoires.Add(newRepertoire.ToString(), newRepertoire);
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
            var id = (selectedItem as string);
            repertoires.TryGetValue(id, out Repertoire selectedRepertoire);
            var formEditRepertoire = new EditRepertoireForm(selectedRepertoire);
            if (formEditRepertoire.ShowDialog() == DialogResult.OK)
            {
                var editedRepertoire = formEditRepertoire.Repertoire;
                repertoires.Remove(id);
                repertoires.Add(editedRepertoire.ToString(), editedRepertoire);
                repertoiresListBox.SelectedItem = editedRepertoire.ToString();
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
                var id = (selectedItem as string);
                repertoires.Remove(id);
                repertoiresListBox.Items.RemoveAt(repertoiresListBox.SelectedIndex);
            }
        }
    }
}
