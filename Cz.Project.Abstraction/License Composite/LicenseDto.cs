using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cz.Project.Abstraction
{
    public class LicenseDto : ComponentDto
    {
        public LicenseDto() { }

        public LicenseDto(string name, int code, int familyLicenseId) : base(name, code, familyLicenseId) { }

        public override void AddChild(ComponentDto c)
        {
            throw new NotImplementedException();
        }

        public override IList<ComponentDto> GetChilds()
        {
            return null;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
