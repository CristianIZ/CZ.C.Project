﻿using Cz.Project.Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cz.Project.Domain
{
    public class EventType : BaseEntity
    {
        public int Code { get; set; }
        public string Name { get; set; }
    }
}
