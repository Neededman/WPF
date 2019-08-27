using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateDemo.ViewModels
{
    class StuViewModel
    {
        public List<Student> Stus { get; set; }

        public StuViewModel()
        {
            this.Stus = new List<Student>();
            this.Stus.Add(new Student(123, "test1", 78));
            this.Stus.Add(new Student(125, "test2", 57));
            this.Stus.Add(new Student(126, "test3", 98));
        }
    }

    class Student
    {
        public Student(int _id, string _name, int _score)
        {
            this.Id = _id;
            this.Name = _name;
            this.Score = _score;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }

    }
}
