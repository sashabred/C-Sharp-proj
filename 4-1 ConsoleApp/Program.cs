using System;
using System.IO;
using System.Xml.Serialization;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
           House bab19 = new House () {Street = "Babushkina", Number = 19};
           bab19.AddFlat(new Flat() {Number =1, Person ="Sabd"});
           bab19.AddFlat(new Flat() {Number =2, Person ="Nahd"});
           bab19.AddFlat(new Flat() {Number = 5, CountPersonLiving =3});
           SerializeXML(bab19);

        }

         private static void SerializeXML(House house) {
            XmlSerializer xml = new XmlSerializer(typeof(House));
            using (FileStream fs = new FileStream("HouseInfo.xml", FileMode.OpenOrCreate))
            {
                xml.Serialize(fs, house);
            }
        }
        private House DeserializeXML() {
             XmlSerializer xml = new XmlSerializer(typeof(House));
            using (FileStream fs = new FileStream("HouseInfo.xml", FileMode.OpenOrCreate))
            {
                return (House) xml.Deserialize(fs);
            }
        }
    }
}
