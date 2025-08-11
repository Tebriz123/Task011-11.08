
using Task10_addition.Models;

namespace Task10_addition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student {
            Name = "Tebriz",
            Surname = "Necefov",
            Age = 20
            
            };
            Student student2 = new Student
            {
                Name = "Aqil",
                Surname = "Kelbiyev",
                Age = 20

            };
            Student student3 = new Student
            {
                Name = "Aykhan",
                Surname = "Huseynov",
                Age = 20

            };
            Student student4 = new Student
            {
                Name = "Shukur",
                Surname = "Askarov",
                Age = 20

            };
            student.PrintInfo();
            Console.WriteLine("--------------------");



            Group group = new Group
            {
                Name = "PB306",
                GroupLimit = 18
            };
            Group group2 = new Group
            {
                Name = "PF306",
                GroupLimit = 10
            };


            group.Add(student);
            group.Add(student2);
            group.Add(student3);
            group.Add(student4);
            group.ShowStudents();
            Console.WriteLine("-------------------------------------");

            string nameSearch = "Elvin";
            if (group.StudentExistis(nameSearch))
            {
                Console.WriteLine("telebe bu qrupdadir");
            }
            else
            {
                Console.WriteLine("Telebe bu qrupda deyil deyil.");
            }

            group.Remove("Tebriz");
            group.ShowStudents();


            University university = new University();   
            university.AddGroup(group);
            university.AddGroup(group2);
            university.ShowGroups();
            university.ShowAllStudents();
          

        }
    }
}
