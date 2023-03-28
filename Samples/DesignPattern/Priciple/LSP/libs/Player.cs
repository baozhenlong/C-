namespace LSP
{
    public class Player : Role
    {
        public Player(string name) : base(name) { }

        // NPC 没有此方法
        public void Attack(Player player)
        {
            Console.WriteLine($"{this.name} 攻击 {player.name}");
        }

        // 重写父类 Hello
        public override void Hello(Role role)
        {
            Console.WriteLine($"我是{this.name}: hi {role.name}");
        }
    }
}