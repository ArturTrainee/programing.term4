using Lab4.Entities;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Lab4.Utils
{
    class XmlEntitiesReader<T> where T : IXmlSerializable, new()
    {
        public static IList<T> ReadEntitiesFrom(string path, string searchNodeName, string stopNodeName) 
        {
            var readingResult = new List<T>();
            try
            {
                using (var fs = new FileStream(path, FileMode.Open, FileAccess.ReadWrite))
                {
                    using (var reader = XmlReader.Create(fs))
                    {
                        reader.MoveToContent();

                        while (reader.Read())
                        {
                            if (reader.Name.Equals(searchNodeName))
                            {
                                T repertoire = new T();
                                repertoire.ReadXml(reader);
                                readingResult.Add(repertoire);
                            }
                            if (reader.Name.Equals(stopNodeName)) break;
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
