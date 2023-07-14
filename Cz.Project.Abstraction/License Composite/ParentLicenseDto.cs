using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cz.Project.Abstraction
{
    public class ParentLicenseDto : ComponentDto
    {
        private IList<ComponentDto> childs;

        public ParentLicenseDto(string name, int code, int familyLicenseId) : base(name, code, familyLicenseId)
        {
            childs = new List<ComponentDto>();
        }

        public ParentLicenseDto()
        {
            childs = new List<ComponentDto>();
        }

        public override void AddChild(ComponentDto c)
        {
            childs.Add(c);
        }

        public override IList<ComponentDto> GetChilds()
        {
            return childs;
        }
    }
}
