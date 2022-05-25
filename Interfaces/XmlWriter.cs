using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class XmlWriter : FileBase,IWriter
    {
        public void WriteFile()
        {
            Console.WriteLine("Writing file in the XML writer");
        }

        public override void SetName()
        {
            base.SetName();
        }
    }
    
}
