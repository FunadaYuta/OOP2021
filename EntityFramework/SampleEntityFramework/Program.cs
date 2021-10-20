using SampleEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEntityFramework {
    class Program {
        static void Main(string[] args) {
            //Console.WriteLine("#1.1");
            //Exercise3_1_1();

            //Console.WriteLine("\n#1.2");
            //Exercise3_1_2();

            //Console.WriteLine("\n#1.3");
            //Exercise3_1_3();

            //Console.WriteLine("\n#1.4");
            //Exercise3_1_4();

            //Console.WriteLine("\n#1.5");
            Exercise3_1_5();

            //Console.WriteLine("\n#2.1");
            //Exercise3_2_1();
            //RegisterAuthor();

            Console.ReadLine();

        }

        private static void Exercise3_2_1() {
            try {
                Console.WriteLine("書籍を追加します");
                Console.Write("タイトルを入力: ");
                string title = Console.ReadLine();
                Console.Write("発行年を入力: ");
                int publishedYear = int.Parse(Console.ReadLine());
                Console.Write("著者名を入力: ");
                string authorName = Console.ReadLine();

                using (var db = new BooksDbContext()) {

                    var authors = db.Authors;
                    int count = 0;
                    foreach (var author in authors) {
                        if (author.Name == authorName) {
                            count++;
                        }
                    }
                    if (count == 0) {
                        Console.WriteLine("著者名が登録されていません\n");
                        RegisterAuthor();//著者を登録
                        Console.WriteLine();
                        Exercise3_2_1();
                        return;
                    }

                    var author1 = db.Authors.Single(a => a.Name == authorName);

                    var book = new Book {
                        Title = title,
                        PublishedYear = publishedYear,
                        Author = author1
                    };
                    db.Books.Add(book);
                    db.SaveChanges();
                    Console.WriteLine($"タイトル:{book.Title} 発行年:{book.PublishedYear} 著者名:{ book.Author.Name} が登録されました");
                }
            }
            catch(Exception ex) {
                Console.WriteLine(ex.Message);
                return;
            }
           
            
        }

        //著者を登録
        private static void RegisterAuthor() {
            try {
                Console.WriteLine("著者を追加します");
                Console.Write("名前を入力: ");
                string AuthorName = Console.ReadLine();
                Console.Write("誕生年を入力(例:2021): ");
                int year = int.Parse(Console.ReadLine());
                Console.Write("誕生月を入力(例:4): ");
                int month = int.Parse(Console.ReadLine());
                Console.Write("誕生日を入力(例:30): ");
                int day = int.Parse(Console.ReadLine());

                Console.Write("性別を入力 男=M 女=F >>");
                string gender = Console.ReadLine();

                if(gender != "M" && gender != "F") {
                    throw new FormatException("入力形式が正しくありませんnnnnnn");
                }

                using(var db = new BooksDbContext()) {
                    var author = new Author {
                        Name = AuthorName,
                        Birthday = new DateTime(year, month, day),
                        Gender = gender
                    };

                    db.Authors.Add(author);
                    db.SaveChanges();
                    Console.WriteLine($"名前:{author.Name} 誕生日:{author.Birthday} 性別:{author.Gender} が登録されました");
                }

            }catch(Exception ex) {
                Console.WriteLine(ex.Message);
                return;
            }
    
        }

        private static void Exercise3_1_5() {
            using (var db = new BooksDbContext()) {
                var authorname = db.Authors.OrderByDescending(x => x.Birthday);
                var books = db.Books.OrderBy(x => x.PublishedYear);
                foreach(var author in authorname) {
                    Console.WriteLine($"↓↓↓{author.Name}({author.Birthday}～)↓↓↓");
                    foreach(var book in books) {
                        if(author.Name == book.Author.Name) {
                            Console.WriteLine($"{book.Title} { book.PublishedYear}");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }

        private static void Exercise3_1_4() {
            using (var db = new BooksDbContext()) {
                var oldTitle = db.Books.OrderBy(x => x.PublishedYear).Take(3);
                foreach(var book in oldTitle) {
                    Console.WriteLine($"{book.Title} {book.Author.Name}");
                }
            }
        }

        private static void Exercise3_1_3() {
            using(var db = new BooksDbContext()) {
                var titles = db.Books.Where(x => x.Title.Length == db.Books.Max(y => y.Title.Length));
                foreach(var title in titles) {
                    Console.WriteLine(title.Title);
                }
                
            }
        }

        private static void Exercise3_1_2() {
            using(var db = new BooksDbContext()) {
                var books = db.Books;
                foreach(var book in books) {
                    Console.WriteLine($"{book.Title} { book.PublishedYear} { book.Author.Name}");
                }
            }
        }

        private static void Exercise3_1_1() {
           
            using (var db = new BooksDbContext()) {
                var author1 = db.Authors.Single(a => a.Name == "夏目漱石");
                var book1 = new Book {
                    Title = "こころ",
                    PublishedYear = 1991,
                    Author = author1,
                };
                db.Books.Add(book1);
                var author2 = db.Authors.Single(a => a.Name == "川端康成");
                var book2 = new Book {
                    Title = "伊豆の踊子",
                    PublishedYear = 2003,
                    Author = new Author {
                        Birthday = new DateTime(1899, 6, 14),
                        Gender = "M",
                        Name = "川端康成"
                    }
                };
                db.Books.Add(book2);
                var author3 = db.Authors.Single(a => a.Name == "菊池寛");
                var book3 = new Book {
                    Title = "真珠婦人",
                    PublishedYear = 2002,
                    Author = new Author {
                        Birthday = new DateTime(1888, 12, 26),
                        Gender = "M",
                        Name = "菊池寛"
                    }
                };
                db.Books.Add(book3);
                var author4 = db.Authors.Single(a => a.Name == "宮沢賢治");
                var book4 = new Book {
                    Title = "注文の多い料理店",
                    PublishedYear = 2000,
                    Author = author4,
                };
                db.Books.Add(book4);
                db.SaveChanges();
            }
        }

        #region p321～p343
        //List 13-5
        static void InsertBooks() {
            using (var db = new BooksDbContext()) {
                var book1 = new Book {
                    Title = "坊ちゃん",
                    PublishedYear = 2003,
                    Author = new Author {
                        Birthday = new DateTime(1867, 2, 9),
                        Gender = "M",
                        Name = "夏目漱石",
                    }
                };
                db.Books.Add(book1);
                var book2 = new Book {
                    Title = "人間失格",
                    PublishedYear = 1990,
                    Author = new Author {
                        Birthday = new DateTime(1909, 6, 19),
                        Gender = "M",
                        Name = "太宰治",
                    }
                };
                db.Books.Add(book2);
                db.SaveChanges();
            }
        }

        //List 13-7
        static IEnumerable<Book> GetBooks() {
            using(var db = new BooksDbContext()) {
                return db.Books
                    .Where(book => book.Author.Name.StartsWith("夏目"))
                    .ToList();
            }
        }

        //List 13-8
        static void DisplayAllBooks() {
            var books = GetBooks();
            foreach(var book in books) {
                Console.WriteLine($"{book.Title} {book.PublishedYear}");
            }
            Console.WriteLine();
        }

        //List 13-9
        private static void AddAuthors() {
            using (var db = new BooksDbContext()) {
                var author1 = new Author {
                    Birthday = new DateTime(1878, 12, 7),
                    Gender = "F",
                    Name = "与謝野晶子"
                };
                db.Authors.Add(author1);
                var author2 = new Author {
                    Birthday = new DateTime(1896, 8, 27),
                    Gender = "M",
                    Name = "宮沢賢治"
                };
                db.Authors.Add(author2);
                db.SaveChanges();
            }
           
        }

        //List 13-10
        private static void AddBooks() {
            using (var db = new BooksDbContext()) {
                var author1 = db.Authors.Single(a => a.Name == "与謝野晶子");
                var book1 = new Book {
                    Title = "みだれ髪",
                    PublishedYear = 2000,
                    Author = author1,
                };
                db.Books.Add(book1);
                var author2 = db.Authors.Single(a => a.Name == "宮沢賢治");
                var book2 = new Book {
                    Title = "銀河鉄道の夜",
                    PublishedYear = 1989,
                    Author = author2,
                };
                db.Books.Add(book2);
                db.SaveChanges();
            }
        }

        //List 13-11
        private static void UpdateBook() {
            using (var db = new BooksDbContext()) {
                var book = db.Books.Single(x => x.Title == "銀河鉄道の夜");
                book.PublishedYear = 2016;
                db.SaveChanges();
            }
        }

        //List 13-12
        private static void DeleteBook() {
            using(var db = new BooksDbContext()) {
                var book = db.Books.SingleOrDefault(x => x.Id == 10);
                if(book != null) {
                    db.Books.Remove(book);
                    db.SaveChanges();
                }
            }
        }
        #endregion

    }
}
