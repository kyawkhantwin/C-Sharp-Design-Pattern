using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesginPattern.src.Behavioral.Observer.GoodExample
{
    public class Subject
    {
        private List<Observer> _observers = new List<Observer>();

        public  void AddObserver(Observer observer)
        {
            _observers.Add(observer);
        }
        public void RemoveObserver(Observer observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }
    }
}