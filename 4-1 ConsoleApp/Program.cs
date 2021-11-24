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
           bab19.AddFlat(new Flat(2, "Sandanova"));
           bab19.AddFlat(new Flat(1));
           bab19.AddFlat(new Flat(3,5));
           SerializeXML(bab19);

        }

         private static void SerializeXML(House house) {
            XmlSerializer xml = new XmlSerializer(typeof(House));
            using (FileStream fs = new FileStream("HouseInfo.xml", FileMode.OpenOrCreate))
            {
                xml.Serialize(fs, house);
            }
        }
    }
}
