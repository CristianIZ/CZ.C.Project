using Cz.Project.Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cz.Project.Domain
{
    public class Order : KeyEntity, VerificationEntity
    {
        public string CheckDigit { get; set; }

        public User User { get; set; }
        public StoreFood Store { get; set; }
        public int Number { get; set; }
        public string Detail { get; set; }
        public int Amount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
