using System;
using InternshipTest.Person;
using InternshipTest.Institution;
using InternshipTest.Institution.InterLink;

namespace InternshipTest
{
    static class Program
    {
        static void Main(string[] args)
        {
            var s = new Student("Alex");
            University university = new University("CH.U.I.");
            university.AddStudent(new Student("Andrew Kostenko", new Knowledge(5)));
            university.AddStudent(new Student("Julia Veselkina", 5));
            university.AddStudent(new Student("Maria Perechrest", 3));
            
            Internship internship = new Internship("Interlink");
            internship.CreatingListOfIntern(university);
            Console.WriteLine("List of internship's students:");
            Console.WriteLine(internship.GetStudents());
            Console.ReadKey();
        }
    }
}
