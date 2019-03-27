using InternshipTest.Person;
using System.Collections.Generic;

namespace InternshipTest.Institution
{
    public class University
    {
        string Name { get; set; }
        List<Student> students;
        public University(string name)
        {
            Name = name;
            students = new List<Student>();
            //TODO: Implementation is needed  
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
            //TODO: Implementation is needed
        }
    }
}
