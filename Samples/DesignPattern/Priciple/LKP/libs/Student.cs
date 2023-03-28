namespace LKP
{
    public class Student
    {
        public string name;
        public Student(string name)
        {
            this.name = name;
        }
        public void Introduce()
        {
            Console.WriteLine($"我是{this.name}");
        }
    }

    internal class HighStudent : Student
    {
        private HighStudent(string name) : base(name)
        {
            this.name = name;
        }
    }
}