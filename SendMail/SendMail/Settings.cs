﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace SendMail {
    public class Settings {

        private static Settings instance = null;

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
            string filepass = @"./settings.xml";
            if (instance == null && File.Exists(filepass)) {
                using (var reader = XmlReader.Create(filepass)) {
                    var serializer = new DataContractSerializer(typeof(Settings));
                    instance = serializer.ReadObject(reader) as Settings;
                }
            }else if (instance == null) {
                instance = new Settings();
            }
            return instance;
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
