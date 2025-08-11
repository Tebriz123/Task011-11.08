
namespace Task10_addition.Models
{
    internal class University
    {
        string _name;
        Group[] _groups = new Group[0];

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
        public Group[] Groups
        {
            get
            {
                return _groups;
            }
            set
            {
                _groups = value;
            }
        }

        

        public void AddGroup(Group group)
        {
            Array.Resize(ref _groups, Groups.Length + 1);
            Groups[Groups.Length-1] = group;
            
        }
        public void RemoveGroup(string name)
        {
           Group[] newGroup = new Group[Groups.Length-1];
            int j = 0;
            for(int i = 0; i < Groups.Length; i++)
            {
                if(Groups[i].Name != name)
                {
                    Groups[j].Name = name;
                    j++;
                }
            }
        }
        public void ShowGroups()
        {
            for(int i = 0;i < Groups.Length;i++)
            {
                Console.WriteLine(Groups[i].Name);
            }
        }
        public void ShowAllStudents()
        {
            for (int i = 0; i < Groups.Length ; i++)
            {
                for(int j = 0; j <  Groups[i].Students.Length; j++)
                {
                    Console.WriteLine(Groups[i].Students[j]);
                }
            }
        }
    }
}
