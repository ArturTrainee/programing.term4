using System;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Lab4.Entities
{
    internal class Performance : IXmlSerializable
    {
        private string name = "";
        private Category category = Category.Drama;
        private Location location;
        private Troupe troupe;
        private DateTime startDate = DateTime.Now;
        private int rentPrice = 0;
        private bool hasOrchestra = false;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Performance name cannot be null or white space");
                }

                name = value;
            }
        }

        public DateTime StartDate
        {
            get
            {
                return startDate;
            }

            set
            {
                startDate = value;
            }
        }

        public int RentPrice
        {
            get
            {
                return rentPrice;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Rent price cannot be less than 0");
                }

                rentPrice = value;
            }
        }

        public bool HasOrchestra
        {
            get { return hasOrchestra; }
            set
            {
                hasOrchestra = value;
            }
        }

        internal Category Category
        {
            get { return category; }
            set
            {
                category = value;
            }
        }

        internal Location Location
        {
            get
            {
                return location;
            }

            set
            {
                if (value is null)
                {
                    throw new ArgumentNullException("Location cannot be null");
                }

                location = value;
            }
        }

        internal Troupe Troupe
        {
            get
            {
                return troupe;
            }

            set
            {
                if (value is null)
                {
                    throw new ArgumentNullException("Troupe cannot be null");
                }

                troupe = value;
            }
        }

        public XmlSchema GetSchema()
        {
            return null;
        }

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
                if (reader.Name.Equals("Performance"))
                {
                    break;
                }
            }
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteElementString("Name", name);
            writer.WriteElementString("Category", category.ToString());
            writer.WriteElementString("StartDate", startDate.ToString());
            writer.WriteElementString("RentPrice", rentPrice.ToString());
            writer.WriteElementString("HasOrchestra", hasOrchestra.ToString());
            writer.WriteStartElement("Location");
            location.WriteXml(writer);
            writer.WriteEndElement();
            writer.WriteStartElement("Troupe");
            troupe.WriteXml(writer);
            writer.WriteEndElement();
        }

        public override string ToString()
        {
            return "Performance {Name: " + name + ", Category: " + category + ", " + location + ", " + troupe + ", Date: " + startDate +
                ", Rent Price: " + rentPrice + ", Has Orchestra: " + hasOrchestra + "}";
        }
    }
}
