using Cz.Project.Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cz.Project.Domain
{
    public class AdminUserLicenses : BaseEntity
    {
        public AdminUsers AdminUser { get; set; }
        public License Licenses { get; set; }
    }
}
