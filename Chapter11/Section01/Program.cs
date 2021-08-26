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
            foreach (var xnovelist in xdoc.Root.Elements()) {
                var xname = xnovelist.Element("name");
                var works = xnovelist.Element("masterpieces").
                    Elements("title").Select(x => x.Value);
                Console.WriteLine("{0} - {1}",
                    xname.Value, string.Join(",", works));

            }
        }
    }
}
