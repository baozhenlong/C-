/// <summary>
/// 策略模式
/// </summary>
using Strategy;

Context context = new Context(new CashNormal());
Console.WriteLine(context.AcceptCash(100));

context = new Context(new CashRebate("0.9"));
Console.WriteLine(context.AcceptCash(100));

context = new Context(new CashReturn("50", "10"));
Console.WriteLine(context.AcceptCash(100));