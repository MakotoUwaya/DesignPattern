using System;

namespace Observer.Model
{
    public class Observer : IObserver<string>
    {
        private string name;

        public Observer(string name)
        {
            this.name = name;
        }

        public void OnCompleted()
        {
            Console.WriteLine($"OnCompleted {this.name}");
        }

        public void OnError(Exception error)
        {
            Console.WriteLine($"OnError {this.name} Error:{error.Message}");
        }

        public void OnNext(string value)
        {
            Console.WriteLine($"OnNext {this.name} Value:{value}");
        }
    }
}
