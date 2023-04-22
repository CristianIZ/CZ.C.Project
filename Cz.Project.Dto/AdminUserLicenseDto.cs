using Cz.Project.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cz.Project.Dto
{
    public class AdminUserLicenseDto
    {
        public AdminUserDto AdminUser { get; set; }
        public List<LicenseDto> Licenses { get; set; }
    }
}
