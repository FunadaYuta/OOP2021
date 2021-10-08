using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using System.Xml;
using System.Xml.Serialization;

namespace SendMail {
    public class Settings {

        private static Settings instance = null;
        static ConfigForm configForm = new ConfigForm();

        //送信データ設定済み
        public static bool Ready { get; set; } = true;

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
            try {
                if (instance == null) {   //instanceがNULLの場合

                    instance = new Settings();

                    string filepass = @"./settings.xml";

                    if (File.Exists(filepass)) {//ファイルがある場合、Xmlファイルを逆シリアライズ化してinstanceに読み込む
                        using (var reader = XmlReader.Create(filepass)) {
                            var serializer = new DataContractSerializer(typeof(Settings));
                            var readersetting = serializer.ReadObject(reader) as Settings;

                            instance.Host = readersetting.Host;
                            instance.Port = readersetting.Port;
                            instance.Pass = readersetting.Pass;
                            instance.MailAddr = readersetting.MailAddr;
                            instance.Ssl = readersetting.Ssl;

                        }
                    } else {    //ファイルがない場合、設定画面を表示する
                        configForm = new ConfigForm();
                        configForm.ShowDialog();
                    }
                }
                return instance;
            }
            catch(Exception ex) {
                MessageBox.Show("XMlファイルが正しく読み取れません。\n" + ex.Message);
                configForm = new ConfigForm();
                configForm.ShowDialog();
                return instance;
            }
            
        }

        public void setSendConfig(string host,int port,string mailAddr,string pass,bool ssl) {  //設定画面でOKもしくは適用したときに呼び出す

            //instanceにTextBoxの内容を格納する
            instance.Host = host;
            instance.Pass = pass;
            instance.Port = port;
            instance.MailAddr = mailAddr;
            instance.Ssl = ssl;

            //instanceの情報をXMｌのファイルにシリアライズ化
            var settings = new XmlWriterSettings {
                Encoding = new System.Text.UTF8Encoding(false),
                Indent = true,
                IndentChars = " ",
            };

            using (var writer = XmlWriter.Create("settings.xml", settings)) {
                var serializer = new DataContractSerializer(instance.GetType());
                serializer.WriteObject(writer, instance);
            }
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
