using Cz.Project.Dto.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cz.Project.Dto
{
    public class BitacoraDto
    {
        public EventTypeEnum Code { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }

        public override string ToString()
        {
            return $"{Code}: {Text}: {Date}";
        }
    }
}
