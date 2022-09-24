namespace LSP
{
    public class Role
    {
        public string name;
        public Role(string name)
        {
            this.name = name;
        }

        public virtual void Hello(Role role)
        {
            Console.WriteLine($"{this.name}: hi {role.name}");
        }
    }
}