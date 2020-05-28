using Lab4.Entities;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace Lab4.Utils
{
    class XmlRepertoiresReader
    {
        public static IList<Repertoire> ReadEntitiesFrom(string path)
        {
            var readingResult = new List<Repertoire>();
            try
            {
                using (var fs = new FileStream(path, FileMode.Open, FileAccess.ReadWrite))
                {
                    using (var reader = XmlReader.Create(fs))
                    {
                        if (reader.EOF) return readingResult;
                        reader.Read();
                        if (reader.IsEmptyElement) return readingResult;
                        while (reader.Read())
                        {
                            if (reader.IsStartElement() && reader.Name.Equals("Repertoire"))
                            {
                                var repertoire = new Repertoire();
                                repertoire.ReadXml(reader);
                                readingResult.Add(repertoire);
                            }
                            if (reader.Name.Equals("Repertoires")) break;
                        }
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(Messages.FILE_READING_EXCEPTION + "\nДеталі помилки: " + ex.Message);
            }
            return readingResult;
        }
    }
}
