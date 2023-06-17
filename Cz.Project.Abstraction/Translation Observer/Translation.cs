using Cz.Project.Abstraction.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cz.Project.Abstraction.Translation_Observer
{
    public class Translation : ITranslation
    {
        private List<ITranslationNotifier> _observers = new List<ITranslationNotifier>();
        public LanguajeDto CurrentLanguaje;

        public void Attach(ITranslationNotifier observer)
        {
            this._observers.Add(observer);
        }

        public void Detach(ITranslationNotifier observer)
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

        public void ChangeLenguaje(LanguajeDto languaje)
        {
            this.CurrentLanguaje = languaje;
            this.Notify();
        }
    }
}
