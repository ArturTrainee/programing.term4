using Lab4.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Lab4.Forms
{
    public partial class MainForm : Form
    {
        internal static readonly string REPERTOIRES_XML_FILE_NAME = "all_repertoires.xml";
        internal static readonly string REPERTOIRES_PATH = Path.Combine(Directory.GetCurrentDirectory(), REPERTOIRES_XML_FILE_NAME);
        internal static readonly string CANCEL_MESSAGE = "Ви самі вибрали _Н_Е_ зберігати";

        private IList<Repertoire> repertoires;

        public MainForm()
        {
            InitializeComponent();
            repertoires = new List<Repertoire>();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                using (var fs = new FileStream(REPERTOIRES_PATH, FileMode.Open, FileAccess.ReadWrite))
                using (var reader = XmlReader.Create(fs))
                {
                    reader.MoveToContent();

                    while (reader.Read())
                    {
                        if (reader.Name.Equals("Repertoire"))
                        {
                            var repertoire = new Repertoire();
                            repertoire.ReadXml(reader);
                            repertoires.Add(repertoire);
                        }
                        if (reader.Name.Equals("ArrayOfRepertoire")) break;
                    }
                }
                foreach (var repertoire in repertoires)
                {
                    listBox1.Items.Add(repertoire.ToShortString());
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Не вдалося знайти файл із раніше збереженими даними,\nпочинаємо <<з чистого листа>>.\nДеталі помилки: {ex.Message}");
                repertoires.Clear();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (var fs = new FileStream(REPERTOIRES_PATH, FileMode.Create, FileAccess.Write))
            using (var writer = XmlWriter.Create(fs, new XmlWriterSettings { Indent = true, ConformanceLevel = ConformanceLevel.Auto }))
            {
                var serializer = new XmlSerializer(typeof(List<Repertoire>));
                serializer.Serialize(writer, repertoires);
            }
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e) => buttonEditSelected.Enabled = true;

        private void ButtonNew_Click(object sender, EventArgs e)
        {
            var formCreateRepertoire = new CreateRepertoireForm();

            if (formCreateRepertoire.ShowDialog() == DialogResult.OK)
            {
                var newRepertoire = formCreateRepertoire.Repertoire;
                listBox1.Items.Add(newRepertoire.ToString());
                repertoires.Add(newRepertoire);
            }
            else
            {
                MessageBox.Show(CANCEL_MESSAGE);
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
            else
            {
                MessageBox.Show(CANCEL_MESSAGE);
            }
        }
    }
}
