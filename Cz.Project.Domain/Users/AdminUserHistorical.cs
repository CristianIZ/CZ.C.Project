using Cz.Project.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Cz.Project.Domain
{
    public class AdminUserHistorical : BaseEntity, IDateAudit
    {
        public AdminUsers User { get; set; }
        public int? UserId { get; set; }
        public string CheckDigit { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        [Required]
        [StringLength(200)]
        public string Password { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
