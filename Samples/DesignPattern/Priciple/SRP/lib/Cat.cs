namespace SRP
{
    public class Cat : Animal
    {
        public Cat(string name) : base(name) { }

        public override void Shout()
        {
            Console.WriteLine("喵~");
        }
    }
}