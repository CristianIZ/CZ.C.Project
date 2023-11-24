using Cz.Project.Domain.Business;
using Cz.Project.Dto.Enums;
using Cz.Project.SQLContext.Enums;
using Cz.Project.SQLContext.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cz.Project.Services
{
    public class StatusService
    {
        public Status GetByCode(StatusCodeEnum code)
        {
            return new StatusContext().GetByCode((int)code);
        }
    }
}
