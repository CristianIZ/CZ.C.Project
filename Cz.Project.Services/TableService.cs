using Cz.Project.Domain.Business;
using Cz.Project.SQLContext.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cz.Project.Services
{
    public class TableService
    {
        public int Add(Table table)
        {
            return new TableContext().Add(table);
        }

        public IEnumerable<Table> GetByFoodPointId(int foodPointId)
        {
            return new TableContext().GetByFoodPointId(foodPointId);
        }

        public IEnumerable<Table> GetAllTables()
        {
            return new TableContext().GetAll();
        }

        public void DeleteTable(Guid qr)
        {
            new TableContext().Delete(qr);
        }
    }
}
