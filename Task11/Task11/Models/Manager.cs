

namespace Task11.Models
{
    internal class Manager : Employee
    {
        private int _bonus;

        public int Bonus
        {
            get
            {
                return _bonus;
            }
            set
            {
                if (value > 0)
                {
                    _bonus = value;
                }
            }
        }

            public override decimal CalculateSalary()
        {
            decimal baseSalary = base.CalculateSalary(); 
            decimal totalSalary = baseSalary + (baseSalary * Bonus / 100);
            return totalSalary;
        }


    }
}
