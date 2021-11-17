using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGame {
    public class Space {
        public string Name { get; set; }

        public static List<Space> Spaces = new List<Space> {
            new Space{Name = "3"},
            new Space{Name = "4"},
            new Space{Name = "5"},
            new Space{Name = "6"},
            new Space{Name = "7"},
            new Space{Name = "8"},
            new Space{Name = "9"},
            new Space{Name = "10"},
        };
    }
}
