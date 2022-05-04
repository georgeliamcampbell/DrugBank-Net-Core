using System;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;

namespace DrugBank.Examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\georg\Desktop\full database.xml";
            
            DrugBankFile drugbank;
            XmlSerializer serializer = new XmlSerializer(typeof(DrugBankFile));
            using (XmlReader reader = XmlReader.Create(path))
            {
                drugbank = (DrugBankFile)serializer.Deserialize(reader);
            }
            
            var x = from drug in drugbank.Drugs
                    where drug.Sequences.Count > 0
                    orderby drug.Name
                    select drug;

            Console.WriteLine("Hello World!");
        }
    }
}
