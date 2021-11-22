using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Pelmanism {
    //カードクラス
    class Card : Button {
        //カードの横幅と高さ
        private const int SizeW = 50, SizeH = 70;

        //カードの絵柄
        public Image Picture { get; set; }
        //カードの状態(true:表 false:裏)
        public bool State { get; set; }
        //カード表面の色
        public Color OpenColor { get; } = Color.White;
        //カード裏面の色
        public Color CloseColor { get; } = Color.LightSeaGreen;

        public Card(Image picture) {
            Picture = picture;
            State = false;
            Size = new Size(SizeW, SizeH);
            BackColor = CloseColor;
            Font = new Font("MS UI Gothic", 14, FontStyle.Bold);
            Enabled = false;
        }

        //カードをオープンする
        public void Open() {
            State = true; //表
            Image = Picture;
            Enabled = false; //選択不可
            BackColor = OpenColor;
        }

        //カードをクローズする
        public void Close() {
            State = false; //裏
            Image = Image.FromFile(@"close1.png");
            Enabled = true; //選択不可
            BackColor = CloseColor;
        }
        //カードをひっくり返す
        public void Turn() {
            if (State)
                Close();    //裏にする
            else
                Open();     //表にする
        }
    }
}