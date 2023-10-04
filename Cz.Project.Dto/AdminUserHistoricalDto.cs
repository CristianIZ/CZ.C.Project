using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Cz.Project.Dto
{
    public class AdminUserHistoricalDto
    {
        public int Id { get; set; }
        public AdminUserDto User { get; set; }
        public string CheckDigit { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public DateTime CreatedDate { get; set; }

        public override string ToString()
        {
            return $"Date: {CreatedDate} UserName: {Name}";
        }
    }
}
