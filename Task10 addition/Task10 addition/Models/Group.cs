

namespace Task10_addition.Models
{
    internal class Group
    {
         string _name;
        int _grouplimit;
        Student[] _students = new Student[0];

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
               _name = value;
            }
        }
        public int GroupLimit
        {
            get
            {
                return _grouplimit;
            }
            set
            {
                if(value >0 && value <= 18)
                {
                    _grouplimit = value;
                }
            }

        }

        public Student[] Students
        {
            get
            {
                return _students;
            }
            set
            {
                _students = value;
            }
        }

        public void Add(Student student)
        {
            Array.Resize(ref _students, Students.Length + 1);
            Students[Students.Length-1] = student;
        }

        public void ShowStudents()
        {
            for(int i = 0; i < Students.Length; i++)
            {
                Students[i].PrintInfo();

            }
        }
        public void Remove(string name)
        {
            Student[] newStudents = new Student[Students.Length - 1];
            int j = 0;
            for(int i = 0; i < Students.Length; i++)
            {
                if(Students[i].Name != name)
                {
                    newStudents[j] = Students[i];

                    j++;
                }
                
            }
            Students = newStudents;
        }

        public bool StudentExistis(string name)
        {
           for(int i = 0; i < Students.Length;i++)
            {
                if (Students[i].Name == name)
                {
                    return true;
                }
            }
           return false;
        }
    }
}
