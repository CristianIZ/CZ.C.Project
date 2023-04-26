using Cz.Project.Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cz.Project.Domain
{
    public class User : KeyEntity, VerificationEntity
    {
        public string CheckDigit { get; set; }

        public string UserName { get; set; }
    }
}
