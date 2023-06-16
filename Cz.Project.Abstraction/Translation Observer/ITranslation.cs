using Cz.Project.Abstraction.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cz.Project.Abstraction.Translation_Observer
{
    public interface ITranslation
    {
        void Attach(ITranslationNotifier observer);
        void Detach(ITranslationNotifier observer);
        void Notify();
    }
}
