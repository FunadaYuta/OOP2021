using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleUnitConverter {

    public class DistanceUnit {
        public string Name { get; set; }
        public double Coefficient { get; set; }
        public override string ToString() {
            return this.Name;
        }
    }

    //メートル単位を表す
    public class MetricUnit : DistanceUnit {
        private static List<MetricUnit> units = new List<MetricUnit> {
            new MetricUnit{ Name = "mm",Coefficient = 1, },
            new MetricUnit{ Name = "cm",Coefficient = 10, },
            new MetricUnit{ Name = "m",Coefficient = 10 * 100, },
            new MetricUnit{ Name = "km",Coefficient = 10 * 100 * 1000, },
        };

        public static ICollection<MetricUnit> Units {
            get { return units; }
        }

        ///<summary>
        /// ヤード単位からメートル単位に変更します
        ///</summary>
        ///<param name="umit">インチ単位</param>
        ///<param name="value">係数</param>
        ///<return> <return/>

        public double FromImperialUnit(ImperialUnit unit, double value) {
            return (value * unit.Coefficient) * 25.4 / this.Coefficient;
        }

    }


    //ヤード単位を表す
    public class ImperialUnit : DistanceUnit {
        private static List<ImperialUnit> units = new List<ImperialUnit> {
            new ImperialUnit{ Name = "in",Coefficient = 1, },
            new ImperialUnit{ Name = "ft",Coefficient = 12, },
            new ImperialUnit{ Name = "yd",Coefficient = 12 * 3, },
            new ImperialUnit{ Name = "ml",Coefficient = 12 * 3 * 1760, },
        };

        public static ICollection<ImperialUnit> Units {
            get { return units; }
        }


        ///<summary>
        /// メートルヤード単位からヤード単位に変更します
        ///</summary>
        ///<param name="umit">メートル単位</param>
        ///<param name="value">係数</param>
        ///<return> <return/>


        public double FromMetricUnit(MetricUnit unit, double value) {
            return (value * unit.Coefficient) / 25.4 / this.Coefficient;
        }

    }

}
