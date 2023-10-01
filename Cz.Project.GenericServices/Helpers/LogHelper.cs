using AutoMapper;
using Cz.Project.Abstraction.Enums;
using Cz.Project.Abstraction.Log_Process;
using Cz.Project.Domain;
using Cz.Project.Dto;
using Cz.Project.Dto.Enums;
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

        public static List<LogDto> GetLogs(int skip, int take)
        {
            try
            {
                return mapper.Map<List<LogDto>>(new LogAndBitacoraContext().GetLogs(skip, take));
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<LogDto> GetByLogType(LogTypeCodeEnum logType, int skip, int take)
        {
            try
            {
                return mapper.Map<List<LogDto>>(new LogAndBitacoraContext().GetByLogType((int)logType, skip, take));
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Log(LogTypeCodeEnum logTypeCode, string message)
        {
            try
            {
                var log = new Log()
                {
                    Type = new EnumContext().GetLogTypeByCode((int)logTypeCode),
                    Message = message,
                    Date = DateTime.Now,
                };

                new LogAndBitacoraContext().AddLog(log);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
