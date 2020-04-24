using System;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Lab4.Entities
{
    internal class Performance : IXmlSerializable
    {
        private string name;
        private Category category;
        private Location location;
        private Troupe troupe;
        private DateTime startDate;
        private int rentPrice;
        private bool hasOrchestra;

        public string Name
        {
            get => name;
            set
            {
                if(string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Performance name cannot be null or white space");
                name = value;
            }
        }

        public DateTime StartDate
        {
            get => startDate;
            set
            {
                if (value < DateTime.Now) throw new ArgumentException("Start date cannot be later than now");
                startDate = value;
            }
        }

        public int RentPrice
        {
            get => rentPrice;
            set
            {
                if (value < 0) throw new ArgumentException("Rent price cannot be less than 0");
                rentPrice = value;
            }
        }

        public bool HasOrchestra { get => hasOrchestra; set => hasOrchestra = value; }

        internal Category Category { get => category; set => category = value; }

        internal Location Location
        {
            get => location;
            set
            {
                if (value is null) throw new ArgumentNullException("Location cannot be null");
                location = value;
            }
        }

        internal Troupe Troupe
        {
            get => troupe;
            set
            {
                if (value is null) throw new ArgumentNullException("Troupe cannot be null");
                troupe = value;
            }
        }

        public override string ToString() => $"Performance {'{'}(Name: {name}, Category: {category}, {location}, {troupe}, Date: {startDate}, Rent Price: {rentPrice}, Has Orchestra: {hasOrchestra}{'}'}";

        public XmlSchema GetSchema() => null;

        public void ReadXml(XmlReader reader)
        {
            while (reader.Read())
            {
                if (reader.IsStartElement())
                {
                    switch (reader.Name)
                    {
                        case "Name":
                            Name = reader.ReadElementContentAsString();
                            break;

                        case "Category":
                            Enum.TryParse(reader.ReadElementContentAsString(), out category);
                            break;

                        case "StartDate":
                            StartDate = DateTime.Parse(reader.ReadElementContentAsString());
                            break;

                        case "RentPrice":
                            RentPrice = int.Parse(reader.ReadElementContentAsString());
                            break;

                        case "HasOrchestra":
                            HasOrchestra = bool.Parse(reader.ReadElementContentAsString());
                            break;

                        case "Location":
                            location = new Location();
                            location.ReadXml(reader);
                            break;

                        case "Troupe":
                            troupe = new Troupe();
                            troupe.ReadXml(reader);
                            break;
                    }
                }
                if (reader.Name.Equals("Performance")) break;
            }
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteStartElement("Name");
            writer.WriteString(name);
            writer.WriteEndElement();

            writer.WriteStartElement("Category");
            writer.WriteString(category.ToString());
            writer.WriteEndElement();

            writer.WriteStartElement("StartDate");
            writer.WriteString(startDate.ToString());
            writer.WriteEndElement();

            writer.WriteStartElement("RentPrice");
            writer.WriteString(rentPrice.ToString());
            writer.WriteEndElement();

            writer.WriteStartElement("HasOrchestra");
            writer.WriteString(hasOrchestra.ToString());
            writer.WriteEndElement();

            writer.WriteStartElement("Location");
            location.WriteXml(writer);
            writer.WriteEndElement();

            writer.WriteStartElement("Troupe");
            troupe.WriteXml(writer);
            writer.WriteEndElement();
        }
    }
}
