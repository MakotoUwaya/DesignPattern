using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive;

namespace Observer.Model
{
    public class Subject : IObservable<string>
    {
        private LinkedList<IObserver<string>> observers;

        public Subject()
        {
            this.observers = new LinkedList<IObserver<string>>();
        }

        public IDisposable Subscribe(IObserver<string> observer)
        {
            if (!this.observers.Contains(observer))
            {
                this.observers.AddLast(observer);
            }

            return new Unsbscriber(this.observers, observer);
        }

        /// <summary>
        /// 配信します。
        /// </summary>
        /// <param name="news">配信するニュース</param>
        public void Deliver(string news)
        {
            foreach (var observer in this.observers)
            {
                if (news == null)
                {
                    observer.OnError(new ArgumentNullException());
                    continue;
                }
                observer.OnNext(news);
            }
        }

        /// <summary>
        /// 配信を終了します。
        /// </summary>
        public void StopDelivering()
        {
            foreach (var observer in this.observers)
            {
                observer.OnCompleted();
            }
            this.observers.Clear();
        }

        private class Unsbscriber : IDisposable
        {
            private readonly LinkedList<IObserver<string>> observers;
            private readonly IObserver<string> observer;

            public void Dispose()
            {
                if (this.observers.Contains(this.observer))
                {
                    this.observers.Remove(this.observer);
                }
            }

            public Unsbscriber(LinkedList<IObserver<string>> observers, IObserver<string> observer)
            {
                this.observers = observers;
                this.observer = observer;
            }
        }
    }
}
