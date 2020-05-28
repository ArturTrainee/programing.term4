using Lab4.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace Lab4.Utils
{
    class XmlRepertoiresWriter
    {
        public static void WriteEntitiesTo(string path, XmlWriterSettings writeSettings, IList<Repertoire> repertoires)
        {
            using (var fs = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                using (var writer = XmlWriter.Create(fs, writeSettings))
                {
                    try
                    {
                        writer.WriteStartElement("Repertoires");
                        foreach (var r in repertoires)
                        {
                            writer.WriteStartElement("Repertoire");
                            r.WriteXml(writer);
                            writer.WriteEndElement();
                        }
                        writer.WriteEndElement();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

    }
}
