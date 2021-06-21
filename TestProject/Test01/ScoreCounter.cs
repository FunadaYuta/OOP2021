using System.Collections.Generic;
using System.IO;

namespace Test01 {
    class ScoreCounter {
        private IEnumerable<Student> _score;

        // コンストラクタ
        public ScoreCounter(string filePath) {
            _score = ReadScore(filePath);
        }


        //メソッドの概要： 学生データを読み込み、Studentオブジェクトのリストを返す
        private static IEnumerable<Student> ReadScore(string filePath) {
            List<Student> students = new List<Student>();
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines) {
                string[] items = line.Split(',');
                Student student = new Student {
                    Name = items[0],
                    Subject = items[1],
                    Score = int.Parse(items[2])
                };

                students.Add(student);
            }
            return students;
        }

        //メソッドの概要： 科目名別で点数の合計を求める
        public IDictionary<string, int> GetPerStudentScore() {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (Student student in _score) {
                if (dict.ContainsKey(student.Subject)) {
                    //すでにコレクションに科目名が追加されている
                    dict[student.Subject] += student.Score;
                } else {
                    //コレクションへ科目名を登録
                    dict[student.Subject] = student.Score;
                }
            }
            return dict;
        }
    }
}
