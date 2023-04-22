using Cz.Project.Abstraction.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cz.Project.Abstraction.Translation_Observer
{
    public class Translation : ITranslation
    {
        private List<IObserver> _observers = new List<IObserver>();
        public LanguajesCodeEnum CurrentLanguaje;

        public void Attach(IObserver observer)
        {
            this._observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            this._observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(this.CurrentLanguaje);
            }
        }

        public void ChangeLenguaje(LanguajesCodeEnum languaje)
        {
            this.CurrentLanguaje = languaje;
            this.Notify();
        }
    }
}
