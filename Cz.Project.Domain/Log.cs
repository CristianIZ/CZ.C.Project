using Cz.Project.Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cz.Project.Domain
{
    public class Log : BaseEntity
    {
        public LogType Type { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
    }
}
