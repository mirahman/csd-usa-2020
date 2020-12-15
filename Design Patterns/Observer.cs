using System;

namespace DesignPatterns {

    public interface IObserver {
        void Update(ISubject subject);
    }

    public interface ISubject {
        void Attach(IObserver observer);
        void Dettach(IObserver observer);
        void Notify();
    }

    public class Message : ISubject {

        public List<IObserver> _observers = new List<IObserver>();

        public void Attach(IObserver observer) {
            this._observers.Add(observer);
        }

        public void Dettach(IObserver observer) {
            this._observers.Remove(observer);
        }

        public void Notify()
        {
            foreach(var observer in _observers) {
                observer.Update(this);
            }
        }

        public void doSomething()
        {
            this.Notify();
        }
    }

    public class Messenger: IObserver {
        void update(objserver) {
            Console.writeln('');
        }
    }

    public class App: IObserver {
        void update(objserver) {
            Console.writeln('');
        }
    }

 
    public class Program {
        static void Main(string[] args) {

           Message listObservers = new Message();
           IObserver observer1 = new Messenger();
           IObserver observer2 = new App();
           listObservers.Attach(observer1);
           listObservers.Attach(observer2);
           listObservers.doSomething();
           listObservers.Dettach(observer2);
           listObservers.doSomething();
        }
    }

}