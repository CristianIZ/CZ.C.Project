using System;
using System.Collections.Generic;
using System.Text;

namespace Cz.Project.Abstraction
{
    public abstract class ComponentDto
    {
        public string _name { get; set; }
        public int LicenseCode { get; set; }
        public int FamilyLicenseId { get; set; }

        public ComponentDto() { }

        public ComponentDto(string name, int code, int familyLicenseId)
        {
            this._name = name;
            this.LicenseCode = code;
            this.FamilyLicenseId = familyLicenseId;
        }

        public string Name { get { return _name; } }
        public abstract void AddChild(ComponentDto c);
        public abstract IList<ComponentDto> GetChilds();
    }
}
