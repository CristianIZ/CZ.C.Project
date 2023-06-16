using Cz.Project.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Cz.Project.Domain
{
    public class Word : BaseEntity
    {
        [Required]
        public Languaje Languaje { get; set; }
        public int LanguajeId { get; set; }
        [Required]
        public int Code { get; set; }
        [Required]
        public string Text { get; set; }
    }
}
