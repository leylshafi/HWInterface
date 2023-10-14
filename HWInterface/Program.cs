using HWInterface.Models;

namespace HWInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // TASK 1
            //Student st;
            //Console.WriteLine("Enter name: ");
            //string name = Console.ReadLine();
            //Console.WriteLine("Enter surname: ");
            //string surname = Console.ReadLine();
            //if (Student.CheckName(ref name) && Student.CheckName(ref surname))
            //    st = new Student(name, surname);
            //else st = null;
            //if (st!=null)
            //{
            //    Console.WriteLine(st);
            //}
            //else Console.WriteLine("Wrong input");

            // TASK2
            //int num = 5;
            //Console.WriteLine(num.IsEven());
            //Console.WriteLine(num.IsOdd());

            //string text = "Leyla2003";
            //Console.WriteLine(text.HasDigit());
            //Console.WriteLine(text.Capitalize());
            //Console.WriteLine("LEYLA2003".CheckPassword());

            // TASK 3
            Group gr = new Group("AB104");
            Group.AddGroup(gr);
            gr.AddStudent(new Student2("Leyla", "shafiyeva"));
            gr.AddStudent(new Student2("adil", "   nasirli   "));
            gr.AddStudent(new Student2("nigar", "shafi"));
            gr.AddStudent(new Student2("     fidan     ", "KaRiM"));

            //gr.GetGroupInfo();
            //foreach (var item in gr.Search("shafi"))
            //{
            //    Console.WriteLine(item);
            //}

            //gr.RemoveStudent(2);
            //Console.WriteLine(gr);
            //foreach (var item in gr.Students)
            //{
            //    Console.WriteLine(item);
            //}

            //gr.ShowStudents();
            //Console.WriteLine(gr.GetStudent(2));
            Group gr2 = new Group("AB200");
            Group.AddGroup(gr2);
            gr2.AddStudent(new Student2("Leyla", "shafiyeva"));
            gr2.AddStudent(new Student2("adil", "   nasirli   "));
            gr2.AddStudent(new Student2("nigar", "shafi"));
            gr2.AddStudent(new Student2("     fidan     ", "KaRiM"));

            Group.ShowAllGroups();

        }
    }
}