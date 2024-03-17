using Cz.Project.Domain.Base;
using Cz.Project.Domain.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Cz.Project.Domain
{
    public class FoodPoint : KeyEntity
    {
        public string Name { get; set; }
        [Required]
        public AdminUsers User { get; set; }
        public IList<Menu> Menu { get; set; }
        public IList<Table> Tables { get; set; }
        public IList<Order> Orders { get; set; }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
