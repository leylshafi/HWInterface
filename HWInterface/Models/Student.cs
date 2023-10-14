using HWInterface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HWInterface.Models
{
    internal class Student : ICodeAcademy
    {
        private static int _count = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CodeEmail { get; set; }

        public Student(string name, string surname)
        {

            Name = name;
            Surname = surname;
            Id = ++_count;
            CodeEmail = GenerateEmail();
        }
        public static bool CheckName(ref string name)
        {
            name = name.Trim();
            if (name.Length > 3 && name.Length < 25)
            {
                name = Char.ToUpper(name[0]) + name.Substring(1).ToLower();
                Regex rg = new Regex("^[A-Z]{1}[a-z]{1,}$");
                if (rg.IsMatch(name)) return true;
                else return false;
            }
            return false;
        }

        public string GenerateEmail()
        {
            if (Name != null && Surname != null)
            {
                string email = Name.ToLower() + "." + Surname.ToLower() + Id.ToString() + "@code.edu.az";
                return email;
            }
            return string.Empty;
        }

        public override string ToString()
        {
            return $@"Id: {Id}
Name: {Name},
Surname: {Surname},
Email: {CodeEmail}";
        }
    }
}
