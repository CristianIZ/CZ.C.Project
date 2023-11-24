using Cz.Project.Domain.Business;
using Cz.Project.SQLContext.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cz.Project.Services
{
    public class TableService
    {
        public IEnumerable<Table> GetByFoodPointId(int foodPointId)
        {
            return new TableContext().GetByFoodPointId(foodPointId);
        }

        public IEnumerable<Table> GetAllTables()
        {
            return new TableContext().GetAll();
        }
    }
}
