namespace LKP
{
    public class School
    {
        public string name;
        public List<Class> classes;

        public School(string name, List<Class> classes)
        {
            this.name = name;
            this.classes = classes;
        }

        /// <summary>
        /// 介绍
        /// </summary>
        public void Introduce()
        {
            Console.WriteLine($"我是{this.name}");
            foreach (var @class in this.classes)
            {
                @class.Introduce();
            }
        }
    }
}