namespace SRP
{
    public class Dog : Animal
    {
        public Dog(string name) : base(name) { }

        public override void Shout()
        {
            Console.WriteLine("汪~");
        }
    }
}