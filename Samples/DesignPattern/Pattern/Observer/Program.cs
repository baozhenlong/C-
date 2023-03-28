/// <summary>
/// 观察者模式
/// </summary>
using Observer;

Subject subject = new Subject();

new ObserverA(subject);
new ObserverB(subject);

subject.State = 1;