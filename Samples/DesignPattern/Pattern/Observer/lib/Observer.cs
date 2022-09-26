namespace Observer
{
    public abstract class Observer
    {
        protected Subject subject;
        public Observer(Subject subject)
        {
            this.subject = subject;
            this.subject.Attach(this);
        }
        public abstract void Update();
    }

    public class ObserverA : Observer
    {
        public ObserverA(Subject subject) : base(subject) { }
        public override void Update()
        {
            Console.WriteLine($"ObserverA state = {this.subject.State}");
        }
    }

    public class ObserverB : Observer
    {
        public ObserverB(Subject subject) : base(subject) { }
        public override void Update()
        {
            Console.WriteLine($"ObserverB state = {this.subject.State}");
        }
    }
}