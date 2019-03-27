namespace InternshipTest.Person
{
    public class Student
    {
        public string Name {  get; }
        public Knowledge Knowledge { get; private set; }
        public Student(string name)
        {
            Name = name;
        }

        public Student(string name, Knowledge knowledge)
        {
            Name = name;
            Knowledge = knowledge;
        }

        public Student(string name, int knowledge)
        {
            Name = name;
            Knowledge = new Knowledge(knowledge);
        }

        public void SetKnowledge(Knowledge knowledge)
        {
            Knowledge = knowledge;
        }

        public void SetKnowledge(int knowledge)
        {
            Knowledge = new Knowledge(knowledge);
        }

        public override string ToString()
        {
            return (Name + Knowledge.Level);
            return base.ToString();
        }
    }
}