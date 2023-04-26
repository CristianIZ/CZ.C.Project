﻿using Cz.Project.Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cz.Project.Domain
{
    public class StoreFood : BaseEntity, VerificationEntity
    {
        public string CheckDigit { get; set; }

        public string Name { get; set; }
    }
}
