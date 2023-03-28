/// <summary>
/// 里氏替换原则
/// </summary>
using LSP;

NPC npc = new NPC("npc");
Player player1 = new Player("玩家1");
Player player2 = new Player("玩家2");

npc.Hello(player1);
player1.Hello(npc);
player1.Attack(player2);
