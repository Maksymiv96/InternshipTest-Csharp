using InternshipTest.Person;
using System.Collections.Generic;

namespace InternshipTest.Institution
{
    public class University
    {
        string Name { get; set; }
        public List<Student> Students { get; private set; }
        public University(string name)
        {
            Name = name;
            Students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }
        
    }
}
