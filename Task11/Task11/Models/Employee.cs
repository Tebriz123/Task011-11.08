

namespace Task11.Models
{
    internal class Employee:Person
    {
        private string _company;
        private decimal _salaryperhour;
        private int _hour;
        private int _experience;

        public string Company
        {
            get
            {
                return _company;
            }
            set
            {
                _company = value;
            }
        }
        public decimal SalaryPerHour
        {
            get
            {
                return _salaryperhour;
            }
            set
            {
                if(value > 0)
                {
                    _salaryperhour = value;
                }
            }
        }
        public int Hour
        {
            get
            {
                return _hour;

            }
            set
            {
                if( value > 0)
                {
                    _hour = value;
                }
            }
        }
        public int Experience
        {
            get
            {
                return _experience;
            }
            set
            {
                if(value > 0)
                {
                    _experience = value;
                }
            }
        }


        public virtual decimal CalculateSalary()
        {
            decimal salary = SalaryPerHour * Hour;
            return salary;
        }
    }
}
