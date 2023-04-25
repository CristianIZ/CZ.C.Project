using System;
using System.Collections.Generic;
using System.Text;

namespace Cz.Project.SQLContext.Interfaces
{
    public interface ISQLContext<T, L> where T : class where L : class
    {
        public T GetValue();
        public T AddValue(T value);
        public void WriteSecurityDigit();
        public T MapEntity(L domainEntity);
    }
}
