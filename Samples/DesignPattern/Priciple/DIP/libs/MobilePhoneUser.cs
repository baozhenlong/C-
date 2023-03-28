
namespace DIP
{
    public abstract class MobilePhoneUser
    {
        public string name;
        public MobilePhoneUser(string name)
        {
            this.name = name;
        }
        public abstract void UsePhone(MobilePhone one, MobilePhone other);
    }

    public class Kid : MobilePhoneUser
    {
        public Kid(string name) : base(name) { }
        public override void UsePhone(MobilePhone one, MobilePhone other)
        {
            Console.WriteLine($"小孩（{this.name}）");
            one.PlayMusic();
        }
    }

    public class Adult : MobilePhoneUser
    {
        public Adult(string name) : base(name)
        {
            this.name = name;
        }
        public override void UsePhone(MobilePhone one, MobilePhone other)
        {
            Console.WriteLine($"大人（{this.name}）");
            one.Call(other);
        }
    }
}