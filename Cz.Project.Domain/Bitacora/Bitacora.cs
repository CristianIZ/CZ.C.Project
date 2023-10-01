using Cz.Project.Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cz.Project.Domain
{
    public class Bitacora : BaseEntity
    {
        public AdminUsers User { get; set; }
        public EventType Type { get; set; }
        public string Text { get; set; }
        public int UserId { get; set; }
        public DateTime Date { get; set; }
    }
}
