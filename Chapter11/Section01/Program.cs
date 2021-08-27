using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            var xdoc = XDocument.Load("novelists.xml");
            var novelists = xdoc.Root.Elements().Select(x => new {
                Name = (string)x.Element("name"),
                Birth = (DateTime)x.Element("birth"),
                Death = (DateTime)x.Element("death"),
            });

            foreach (var novelist in novelists) {
                Console.WriteLine("{0} ({1}-{2})",novelist.Name,novelist.Birth.Year,novelist.Death.Year);
            }
        }
    }
}

        
