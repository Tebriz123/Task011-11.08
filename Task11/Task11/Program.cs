using Task11.Models;

namespace Task11
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Person person = new Person {
            Name = "Tebriz",
            Surname = "Necefov"
            
            };

            Console.WriteLine(person.ToString());
            Console.WriteLine("---------------------------");
            Employee employee = new Employee
            {
                Name = "Tebriz",
                Surname = "Necefov",
                Company = "Pasha Holding",
                SalaryPerHour = 15m,
                Hour = 9,
                Experience = 2

            };
            Console.WriteLine(person.ToString());
            Console.WriteLine(employee.CalculateSalary());
            Console.WriteLine("-------------------------");



            Manager manager = new Manager
            {
                Name = "Tebriz",
                Surname = "Necefov",
                Company = "Pasha Holding",
                SalaryPerHour = 15m,
                Hour = 9,
                Experience = 2,
                Bonus = 10

            };
            Console.WriteLine(manager.ToString());
            Console.WriteLine(manager.CalculateSalary());
        }
    }
}
