using System;
using System.Collections.Generic;
using System.Text;

namespace Cz.Project.Abstraction.Log_Process
{
    public class LogDto
    {
        public LogTypeDto Type { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }

        public override string ToString()
        {
            return $"{Type.Code}: {Message}: {Date}";
        }
    }
}
