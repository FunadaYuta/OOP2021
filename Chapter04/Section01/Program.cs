using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            var Session = new Dictionary<string, object>();
            Session["MyProduct"] = new Product();
            var product = Session["MyProduct"] as Product;

            if(product == null) {
                Console.WriteLine("productが取得できなかった");
            } else {
                Console.WriteLine("productが取得できた");
                Console.WriteLine(product);
            }
        }






        private static Product GetProductA() {
            Sale sale = new Sale();
           
            return sale?.Product;//null条件演算子
        }

    }
    class Sale {
        public string ShopName { get; set; } = "くぁｗせｄｒｆｔｇｙふじこｌｐ";
        public int Amount { get; set; } = 12343;
        public Product Product { get; set; } 
    }


}
