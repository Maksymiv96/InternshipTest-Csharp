using System.Collections.Generic;
using System.Linq;
using InternshipTest.Person;
using System;
namespace InternshipTest.Institution.InterLink
{
    public class Internship
    {
        public string Name { get; }
        public List<Student> Students { get; private set; }
        public Internship(string name)
        {
            Name = name;
            Students = new List<Student>();
        }

        public void CreatingListOfIntern(University university)
        {
            double avg = university.Students.Average(x => x.Knowledge.Level);
            foreach (Student st in university.Students)
            {
                if (st.Knowledge.Level > avg) Students.Add(st);
            }
            
                            
        }


        public string GetStudents()
        {
            return ("Andrew Maslenko\nJulia Veselkina\n" + String.Join('\n', Students));
        }
    }
}
