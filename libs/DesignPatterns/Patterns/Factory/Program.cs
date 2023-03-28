/// <summary>
/// 工厂模式
/// </summary>
using Factory;

BinaryOperation plus = BinaryOperationFactory.Create("+");
plus.SetOperand(1, 2);
Console.WriteLine(plus.GetResult());