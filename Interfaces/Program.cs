using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Program
    {
        static void Main(string[] args)
        {
            IWriter writer = new XmlWriter();
            writer.WriteFile();

            XmlWriter xmlWriter = new XmlWriter();
            JsonWriter jsonWriter = new JsonWriter();

            FileWriter fileWriter = new FileWriter(xmlWriter);
            fileWriter.Write();

            fileWriter = new FileWriter(jsonWriter);
            fileWriter.Write();
        }
    }
}
