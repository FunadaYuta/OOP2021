using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercise2 {
    class Program {
        static void Main(string[] args) {
            var newfile = "newfile.xml";
            var xdoc = XDocument.Load("11_2.xml");
            var words = xdoc.Root.Elements()
                                 .Select(x =>
                                     new XElement("word",
                                      new XAttribute("kanji", x.Element("kanji").Value),
                                     new XAttribute("yomi", x.Element("yomi").Value)
                                  )
                                );
            var root = new XElement("difficultkanji", words);
            root.Save(newfile);


        
            
        }
    }
}
