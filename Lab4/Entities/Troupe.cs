using System;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Lab4.Entities
{
    public class Troupe : IXmlSerializable
    {
        private string name;
        private int actorsAmount;
        private int actorsSalary;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Name cannot be null or white space");
                name = value;
            }
        }

        public int ActorsAmount
        {
            get
            {
                return actorsAmount;
            }

            set
            {
                if (value < 1) throw new ArgumentException("Actors amount cannot be less than 1");
                actorsAmount = value;
            }
        }

        public int ActorsSalary
        {
            get
            {
                return actorsSalary;
            }

            set
            {
                if (value < 0) throw new ArgumentException("Actors salary cannot be less than 0");
                actorsSalary = value;
            }
        }

        public override string ToString()
        {
            return "Troupe {Name: " + name + ", Actors Amount: " + actorsAmount + ", Actors Salary: " + actorsSalary + "}";
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

                        case ("ActorsAmount"):
                            ActorsAmount = int.Parse(reader.ReadElementContentAsString());
                            break;

                        case "ActorsSalary":
                            ActorsSalary = int.Parse(reader.ReadElementContentAsString());
                            break;
                    }
                }
                if (reader.Name.Equals("Troupe")) break;
            }
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteStartElement("Name");
            writer.WriteString(name);
            writer.WriteEndElement();

            writer.WriteStartElement("ActorsAmount");
            writer.WriteString(actorsAmount.ToString());
            writer.WriteEndElement();

            writer.WriteStartElement("ActorsSalary");
            writer.WriteString(actorsSalary.ToString());
            writer.WriteEndElement();
        }
    }
}
