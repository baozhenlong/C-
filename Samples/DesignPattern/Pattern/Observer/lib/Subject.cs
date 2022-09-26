using System.Collections.Generic;

namespace Observer
{
    public class Subject
    {
        private List<Observer> observers = new List<Observer>();
        private int state;
        public int State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
                this.NotifyAllObservers();
            }
        }

        public void Attach(Observer observer)
        {
            this.observers.Add(observer);
        }
        public void NotifyAllObservers()
        {
            for (int i = 0; i < this.observers.Count; i++)
            {
                this.observers[i].Update();
            }
        }
    }
}