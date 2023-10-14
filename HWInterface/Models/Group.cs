using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWInterface.Models
{
    internal class Group
    {
        public static Group[] Groups = new Group[0];
        private static int _groupCount = 0;

        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public Student2[] Students { get; set; }

        public Group(string groupName)
        {
            GroupId = ++_groupCount;
            GroupName = groupName;
            Students = new Student2[0];
        }

        public void GetGroupInfo()
        {
            Console.WriteLine($@"Group id: {GroupId}
Group Name: {GroupName},
Count of students: {Students.Length}");
        }

        public Student2 GetStudent(int id)
        {
            foreach (Student2 st in Students)
            {
                if (st.Id == id)
                {
                    return st;
                }
            }
            return null;
        }

        public void AddStudent(Student2 student)
        {
            var temp = Students;
            Array.Resize(ref temp, Students.Length + 1);
            temp[^1] = student;
            Students = temp;
        }

        public Student2[] Search(string srch)
        {
            return Students.Where(s => s.Name.ToLower().Contains(srch.ToLower()) || s.Surname.ToLower().Contains(srch.ToLower())).ToArray();
        }

        public void RemoveStudent(int id)
        {
            var temp = Students;
            Array.Resize(ref temp, Students.Length - 1);
            for (int i = 0, j = 0; i < Students.Length; i++)
            {
                if (Students[i].Id != id)
                {
                    temp[j] = Students[i];
                    j++;
                }
            }
            Students = temp;
        }

        public void ShowStudents()
        {
            foreach (var st in Students)
            {
                Console.WriteLine();
                Console.WriteLine(st);
            }
        }

        public static void ShowAllGroups()
        {
            foreach (var gr in Groups)
            {
                Console.WriteLine();
                Console.WriteLine(gr);
            }
        }

        public static void AddGroup(Group group)
        {
            if (!Groups.Any(x => x.GroupName == group.GroupName))
            {
                var temp = Groups;
                Array.Resize(ref temp, Groups.Length + 1);
                temp[^1] = group;
                Groups = temp;
            }
        }


        public override string ToString()
        {
            return $@"Group id: {GroupId},
GroupName: {GroupName}
Student count: {Students.Length}";
        }

    }
}
