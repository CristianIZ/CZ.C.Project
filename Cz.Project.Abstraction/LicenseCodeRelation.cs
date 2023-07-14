using Cz.Project.Abstraction.License_Composite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cz.Project.Abstraction
{
    public class LicenseCodeRelation
    {
        public int Id { get; set; }
        public int ParentCode { get; set; }
        public int ChildCode { get; set; }
        public FamilyLicenseDto FamilyLicense { get; set; }
    }
}
