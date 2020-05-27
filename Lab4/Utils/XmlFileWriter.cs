using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Lab4.Utils
{
    class XmlFileWriter<T>
    {
        public static void WriteEntitiesTo(string path, IList<T> entities)
        {
            using (var fs = new FileStream(path, FileMode.CreateNew, FileAccess.Write))
            {
                var writeSettings = new XmlWriterSettings();
                writeSettings.Indent = true;
                writeSettings.ConformanceLevel = ConformanceLevel.Auto;
                using (var writer = XmlWriter.Create(fs, writeSettings))
                {
                    var serializer = new XmlSerializer(typeof(List<T>));
                    try
                    {
                        serializer.Serialize(writer, entities);
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
