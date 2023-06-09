﻿using Cz.Project.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Cz.Project.Domain
{
    public class Languaje : BaseEntity
    {
        [Required]
        public int Code { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
