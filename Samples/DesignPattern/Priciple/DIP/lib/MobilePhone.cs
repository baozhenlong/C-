namespace DIP
{
    public abstract class MobilePhone
    {
        public string name;
        public string owner;
        public MobilePhone(string name, string owner)
        {
            this.name = name;
            this.owner = owner;
        }
        public abstract void Call(MobilePhone phone);
        public abstract void PlayMusic();
    }

    public class MiUI : MobilePhone
    {
        public MiUI(string name, string owner) : base(name, owner) { }

        public override void Call(MobilePhone phone)
        {
            Console.WriteLine($"用{this.owner}的{this.name}手机给{phone.owner}的{phone.name}手机打电话");
        }
        public override void PlayMusic()
        {
            Console.WriteLine($"用{this.owner}的{this.name}手机听音乐");
        }
    }

    public class Huawei : MobilePhone
    {
        public Huawei(string name, string owner) : base(name, owner) { }

        public override void Call(MobilePhone phone)
        {
            Console.WriteLine($"用{this.owner}的{this.name}手机给{phone.owner}的{phone.name}手机打电话");
        }
        public override void PlayMusic()
        {
            Console.WriteLine($"用{this.owner}的{this.name}手机听音乐");
        }
    }


}