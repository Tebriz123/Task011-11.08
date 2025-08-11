

namespace Task11.Models
{
    internal class Person
    {
        private string _name;
        private string _surname;


        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                value = value.Trim();
                if(value.Length > 0)
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
                if(value.Length > 2)
                {
                    _surname = value;

                }
                

            }
        }

        public override string ToString()
        {
            return $"{Name} {Surname}";
        }
    }
}
