using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter {
    //フィートとメートルの単位変換クラス 
    public class FeetConverter {
        //メートルからフィートを求める
        public double FromMeter(double meter) {
            return meter / 0.3048;
        }

        //フィートからメートルを求める
        public double ToMeter(double feet) {
            return feet * 0.3048;
        }
    }
}
