using System;
using System.Collections.Generic;
using System.Text;

namespace Cz.Project.SQLContext.Interfaces
{
    public interface IRowIntegrityCheck<T> where T : class
    {
        void CheckTableIntegrity();
        void CheckRowIntegrity(T domainEntity);
    }
}
