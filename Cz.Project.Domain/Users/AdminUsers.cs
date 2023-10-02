using Cz.Project.Domain.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cz.Project.Domain
{
    public class AdminUsers : KeyEntity, VerificationEntity
    {
        public string CheckDigit { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        [Required]
        [StringLength(200)]
        public string Password { get; set; }
    }
}
