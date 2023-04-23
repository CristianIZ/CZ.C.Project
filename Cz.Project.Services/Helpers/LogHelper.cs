using Cz.Project.Abstraction.Enums;
using Cz.Project.Domain;
using Cz.Project.SQLContext.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cz.Project.Services.Helpers
{
    public static class LogHelper
    {
        public static void Log(LogTypeCodeEnum logTypeCode, string message)
        {
            var logType = new LogTypeContext().GetByCode((int)logTypeCode);

            try
            {
                new LogContext().Add(new Log()
                {
                    Type = logType,
                    Message = message
                });
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
