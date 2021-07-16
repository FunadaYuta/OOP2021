using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarReportSystem {
    [Serializable]
    public class CarReport {

        
        [DisplayName("日付")]
        public DateTime Date { get; set; }  //日付
        [DisplayName("記録者")]
        public String Auther { get; set; }  //記録者
        [DisplayName("メーカー")]
        public MakerGroup Maker { get; set; } //メーカー
        [DisplayName("車名")]
        public string CarName { get; set; } //車名
        [DisplayName("レポート")]
        public string Report { get; set; } //レポート
        [DisplayName("画像")]
        public Image Picture { get; set; } //画像

        //メーカー
        public enum MakerGroup {
            トヨタ,
            日産,
            ホンダ,
            スバル,
            外国車,
            その他
        }


        
        //データ更新
        public void UpDate(DateTime date,
                        String auther,
                        MakerGroup maker,
                        String carname,
                        string report,
                        Image picture) {
            this.Date = date;
            this.Auther = auther;
            this.Maker = maker;
            this.CarName = carname;
            this.Report = report;
            this.Picture = picture;
        }

       
    }


    

}
