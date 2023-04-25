using AutoMapper;
using Cz.Project.Abstraction.Enums;
using Cz.Project.Abstraction.Log_Process;
using Cz.Project.Domain;
using Cz.Project.SQLContext.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cz.Project.GenericServices.Helpers
{
    public class LogHelper
    {
        public static IMapper mapper = InitializeMapper();

        public static IMapper InitializeMapper()
        {
            var config = new AutoMapperProfiles();
            return new Mapper(config.MapConfig());
        }

        public static void Log(LogTypeCodeEnum logTypeCode, string message)
        {
            try
            {
                var log = new Log()
                {
                    Type = new LogTypeContext().GetByCode((int)logTypeCode),
                    Message = message
                };

                new LogContext().Add(log);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
