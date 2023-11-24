using Cz.Project.Abstraction.Translation_Observer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cz.Project.Services.Simulator
{
    public interface ICookingSimulator
    {
        void Attach(ICookingNotifier observer);
        void Detach(ICookingNotifier observer);
        void Notify();
    }
}
