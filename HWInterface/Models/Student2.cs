using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWInterface.Models
{
    internal class Student2
    {
        private static int _count = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public Student2(string name, string surname)
        {
            Id = ++_count;
            Name = name.Trim().Capitalize();
            Surname = surname.Trim().Capitalize();
        }

        public override string ToString()
        {
            return $@"Id: {Id},
Name: {Name},
Surname: {Surname}";
        }
    }
}
