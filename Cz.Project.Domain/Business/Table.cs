using Cz.Project.Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cz.Project.Domain.Business
{
    public class Table : BaseEntity
    {
        public Guid QR { get; set; }
        public int FoodPointId { get; set; }

        public override string ToString()
        {
            return this.QR.ToString();
        }
    }
}
