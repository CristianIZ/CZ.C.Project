using System;
using System.Collections.Generic;
using System.Text;

namespace Cz.Project.Dto
{
    public class DigitColumnVerificationDto
    {
        public string Table { get; set; }
        public string Column { get; set; }
        public string VerificationDigit { get; set; }
    }
}
