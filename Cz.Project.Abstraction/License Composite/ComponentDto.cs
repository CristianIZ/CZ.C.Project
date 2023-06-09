﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Cz.Project.Abstraction
{
    public abstract class ComponentDto
    {
        public string _name { get; set; }
        public int LicenseCode { get; set; }

        public ComponentDto() { }

        public ComponentDto(string name, int code)
        {
            this._name = name;
            this.LicenseCode = code;
        }

        public string Name { get { return _name; } }
        public abstract void AddChild(ComponentDto c);
        public abstract IList<ComponentDto> GetChilds();
    }
}
