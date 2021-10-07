using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Xml;
using System.Xml.Serialization;

namespace SendMail {
    public class Settings {

        private static Settings instance = null;
        static ConfigForm configForm = new ConfigForm();

        public string Host { get; set; }    //ホスト名
        public string MailAddr { get; set; }    //メールアドレス
        public string Pass { get; set; }    //パスワード
        public int Port { get; set; }   //ポート番号
        public bool Ssl { get; set; }   //SSL

        //コンストラクタ
        private Settings() {
           
        }

        //インスタンスの取得
        public static Settings GetInstance() {

            if(instance == null) {   //instanceがNULLの場合
                instance = new Settings();

                string filepass = @"./settings.xml";

                if (!File.Exists(filepass)) {//ファイルがない場合
                    configForm = new ConfigForm();
                    configForm.ShowDialog();    //設定画面を表示する
                } else {
                    using (var reader = XmlReader.Create(filepass)) {
                        var serializer = new DataContractSerializer(typeof(Settings));
                        var readersetting = serializer.ReadObject(reader) as Settings;

                        instance.Host = readersetting.Host;
                        instance.Port = readersetting.Port;
                        instance.Pass = readersetting.Pass;
                        instance.MailAddr = readersetting.MailAddr;
                        instance.Ssl = readersetting.Ssl;

                    }
                }
            }
            return instance;
        }

        public void setSendConfig(string host,int port,string mailAddr,string pass,bool ssl) {
            instance.Host = host;
            instance.Pass = pass;
            instance.Port = port;
            instance.MailAddr = mailAddr;
            instance.Ssl = ssl;
        }

        public string sHost() {
            return "smtp.gmail.com";
        }
        public string sPort() {
            return 587.ToString();
        }
        public string sMailAddr() {
            return "ojsinfosys01@gmail.com";
        }
        public string sPass() {
            return "Infosys2021";
        }
        public bool sSsl() {
            return true;
        }
       

       
    }
}
