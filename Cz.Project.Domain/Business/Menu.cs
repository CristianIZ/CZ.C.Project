using Cz.Project.Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cz.Project.Domain.Business
{
    public class Menu : BaseEntity
    {
        public string Description { get; set; }
        public IList<Section> Sections { get; set; }
    }
}
