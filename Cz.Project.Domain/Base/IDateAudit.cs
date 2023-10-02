using System;
using System.Collections.Generic;
using System.Text;

namespace Cz.Project.Domain.Base
{
    public interface IDateAudit
    {
        public DateTime CreatedDate { get; set; }
    }
}
