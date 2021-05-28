using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Song {

        public string Title { get; set; }
        public string ArtistName { get;set; }
        public int Length { get; set; }

        public Song(string title,string artistname,int length) {
            this.Title = title;
            this.ArtistName = artistname;
            this.Length = length;
        }

       

    }
}
