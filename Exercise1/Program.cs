using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {
            List<Song> songs = new List<Song>() {
                new Song("unko", "tinko", 60),
                new Song("tinko", "tinko", 300),
                new Song("choko", "tinko", 1416)
            };

            PrintSongs(songs);
            
        }

        private static void PrintSongs(List<Song> songs) {
            foreach(var s in songs){
                Console.Write(@"{0}, {1}, {2:m\:ss}", s.Title, s.ArtistName, TimeSpan.FromSeconds(s.Length));
                Console.WriteLine();
            }
        }
    }
}
