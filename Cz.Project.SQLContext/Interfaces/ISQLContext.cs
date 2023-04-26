using System;
using System.Collections.Generic;
using System.Text;

namespace Cz.Project.SQLContext.Interfaces
{
    public interface ISQLContext<T, L> where T : class where L : class
    {
        public T GetByKey(string key);
        public void Add(T value);
        public T MapEntity(L domainEntity);
    }
}
