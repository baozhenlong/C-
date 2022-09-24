namespace LKP
{
    public class Class
    {
        public string name;
        public List<Student> students;
        public Class(string name, List<Student> students)
        {
            this.name = name;
            this.students = students;
        }
        public void Introduce()
        {
            Console.WriteLine($"我是{this.name}");
            foreach (var student in this.students)
            {
                student.Introduce();
            }
        }
    }
}