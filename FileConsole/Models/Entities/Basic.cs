using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling.Models.Entities
{
    public class Basic : BaseEntity
    {
        public string CategoryId { get; set; }
        public string Name { get; set; } = default!;
        public List<string> Subjects { get; set; } = new List<string>();

        public static Basic ToBasic(string str)
        {
            var model = str.Split('\t');

            var basic = new Basic()
            {
                Id = model[0],
                CategoryId = model[1],
                Name = model[2],
                Subjects = model[3].Split('|').ToList(),
                IsDeleted = bool.Parse(model[4]),
            };
            return basic;
        }

        public override string ToString()
        {
            var sbj = new StringBuilder();
            for (int i = 0; i < Subjects.Count; i++)
            {
                if (i != Subjects.Count - 1)
                {
                    sbj.Append($"{Subjects[i]}|");
                }
                else
                {
                    sbj.Append($"{Subjects[i]}");
                }
            }
            return $"{Id}\t{CategoryId}\t{Name}\t{sbj}\t{IsDeleted}";
        }

    }
}
