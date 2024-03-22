using Cz.Project.Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cz.Project.Domain.Business
{
    public class Menu : BaseEntity
    {
        public string Description { get; set; }
        public int FoodPointId { get; set; }
        public IList<Section> Sections { get; set; }
        public bool IsDeleted { get; set; }

        public override string ToString()
        {
            return this.Description;
        }
    }
}
