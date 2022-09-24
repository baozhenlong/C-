namespace SRP
{
    public abstract class Animal
    {
        public string name;

        public Animal(string name)
        {
            this.name = name;
        }

        // 每个动物的行为不一样
        public abstract void Shout();
    }
}