namespace LSP
{
    public class NPC : Role
    {
        public NPC(string name) : base(name)
        {

        }

        public void ReadMe()
        {
            Console.WriteLine("我是 NPC");
        }
    }
}