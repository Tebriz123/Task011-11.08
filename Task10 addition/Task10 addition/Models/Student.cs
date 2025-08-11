
using System.ComponentModel.Design;
using System.Text;

namespace Task10_addition.Models
{
    internal class Student
    {
       string _name;
        string _surname;
        int _age;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                value = value.Trim();
                if (value.Length > 3)
                {
                    _name = value;
                }
            }
        }
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                value = value.Trim();
                if (value.Length > 3)
                {
                    _surname = value;
                }
                
            }
        }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if(value >= 18)
                _age = value;
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Name:{Name}; Surname: {Surname}; Age: {Age}");
        }

        public override string ToString()
        {
            return Name;
        }
      


    }
}
