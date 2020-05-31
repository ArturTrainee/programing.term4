using System;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Lab4.Entities
{
    public class Location : IXmlSerializable
    {
        private string name = "";
        private string address = "";
        private int rentalPrice = 0;
        private int freeSeatsAmount = 0;
        internal static int orchestraPrice = 0;

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

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Address cannot be null or white space");
                address = value;
            }
        }

        public int RentalPrice
        {
            get
            {
                return rentalPrice;
            }

            set
            {
                if (value < 0) throw new ArgumentException("Rental price cannot be less than 0");
                rentalPrice = value;
            }
        }

        public int FreeSeatsAmount
        {
            get
            {
                return freeSeatsAmount;
            }

            set
            {
                if (value < 0) throw new ArgumentException("Free seats amount cannot be less than 0");
                freeSeatsAmount = value;
            }
        }

        public static int OrchestraPrice
        {
            get
            {
                return orchestraPrice;
            }

            set
            {
                if (value < 0) throw new ArgumentException("Orchestra price cannot be less than 0");
                orchestraPrice = value;
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
                        case "Address":
                            Address = reader.ReadElementContentAsString();
                            break;
                        case "RentalPrice":
                            RentalPrice = int.Parse(reader.ReadElementContentAsString());
                            break;
                        case "FreeSeatsAmount":
                            FreeSeatsAmount = int.Parse(reader.ReadElementContentAsString());
                            break;
                        case "OrchestraPrice":
                            OrchestraPrice = int.Parse(reader.ReadElementContentAsString());
                            break;
                    }
                }
                if (reader.Name.Equals("Location")) break;
            }
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteElementString("Name", name);
            writer.WriteElementString("Address", address);
            writer.WriteElementString("RentalPrice", rentalPrice.ToString());
            writer.WriteElementString("FreeSeatsAmount", freeSeatsAmount.ToString());
            writer.WriteElementString("OrchestraPrice", orchestraPrice.ToString());
        }

        public override string ToString()
        {
            return "Location {Name: " + name + ", Address: " + address + ", Rental Price: " + rentalPrice + ", Free Seats Amount: " +
                freeSeatsAmount + ", Orchestra Price: " + orchestraPrice + "}";
        }
    }
}
