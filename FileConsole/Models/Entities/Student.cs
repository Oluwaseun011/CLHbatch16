using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling.Models.Entities
{
    public class Student : BaseEntity
    {
        public string UserId { get; set; }
        public string BasicId { get; set; }
        public string MatricNumber { get; set; }
        public Dictionary<string, int> Scores { get; set; } = new Dictionary<string, int>();

        public override string ToString()
        {
            var scr = new StringBuilder();
            {
                foreach (var item in Scores)
                {
                    scr.Append($"{item.Key}->{item.Value},");
                }
            }
            return $"{Id}\t{UserId}\t{MatricNumber}\t{scr}\t{IsDeleted}";
        }

        public static Student ToStudent(string str)
        {
            var model = str.Split('\t');

            Dictionary<string, int> scr = new();
            var b = model[4].Split(',');
            for (int i = 0; i < b.Length - 1; i++)
            {
                var c = b[i].Split("->");
                scr.Add(c[0], int.Parse(c[1]));
            }
            var student = new Student()
            {
                Id = model[0],
                UserId = model[1],
                BasicId = model[2],
                MatricNumber = model[3],
                Scores = scr,
                IsDeleted = bool.Parse(model[5]),
            };
            return student;
        }
    }
}
