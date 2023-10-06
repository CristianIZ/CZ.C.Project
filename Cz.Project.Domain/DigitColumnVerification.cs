using Cz.Project.Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cz.Project.Domain
{
    public class DigitColumnVerification : BaseEntity
    {
        public string Table { get; set; }
        public string Column { get; set; }
        public string VerificationDigit { get; set; }
    }
}
