using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Lab4.Entities
{
    public class Repertoire : IXmlSerializable
    {
        private string locationName = "";
        private IList<Performance> performances = new List<Performance>();

        public string LocationName
        {
            get { return locationName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Location name cannot be null or white space");
                locationName = value;
            }
        }

        internal IList<Performance> Performances
        {
            get { return performances; }
            set
            {
                if (value is null) throw new ArgumentNullException("Performances list cannot be null");
                performances = value;
            }
        }

        internal Performance GetPerformanceByToString(string searchedItem)
        {
            return performances.Where(p => p.ToString().Equals(searchedItem)).First();
        }

        public XmlSchema GetSchema() => null;

        public void ReadXml(XmlReader reader)
        {
            while (reader.Read())
            {
                if (reader.IsStartElement())
                {
                    if (reader.Name.Equals("LocationName"))
                    {
                        LocationName = reader.ReadElementContentAsString();
                    }
                    if (reader.Name.Equals("Performances"))
                    {
                        if (reader.IsEmptyElement) return;
                        while (reader.Read())
                        {
                            if (reader.IsStartElement() && reader.Name.Equals("Performance"))
                            {
                                var performance = new Performance();
                                try
                                {
                                    performance.ReadXml(reader);
                                    performances.Add(performance);
                                }
                                catch (ArgumentException)
                                {
                                }
                            }
                            if (reader.Name.Equals("Performances")) break;
                        }
                    }
                }
                if (reader.Name.Equals("Repertoire")) break;
            }
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteElementString("LocationName", locationName);
            writer.WriteStartElement("Performances");
            foreach (var p in performances)
            {
                writer.WriteStartElement("Performance");
                p.WriteXml(writer);
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
        }

        public string ToShortString()
        {
            return "Repertoire {Location Name: " + locationName + ", Performances amount: " + performances.Count + "}";
        }

        public override string ToString()
        {
            return "Repertoire {LocationName: " + locationName + ", Performances: " +
                string.Join("; ", performances.Select(p => p.ToString()).ToArray())
                 + "}";
        }
    }
}
