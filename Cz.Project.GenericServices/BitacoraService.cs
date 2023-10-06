using AutoMapper;
using Cz.Project.Abstraction.Enums;
using Cz.Project.Domain;
using Cz.Project.Dto;
using Cz.Project.Dto.Enums;
using Cz.Project.GenericServices.Helpers;
using Cz.Project.SQLContext;
using Cz.Project.SQLContext.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Cz.Project.GenericServices
{
    public class BitacoraService
    {
        public IMapper mapper;

        public BitacoraService()
        {
            mapper = InitializeMapper();
        }

        public IMapper InitializeMapper()
        {
            var config = new AutoMapperProfiles();
            return new Mapper(config.MapConfig());
        }

        public List<BitacoraDto> Get(int skip, int take)
        {
            var bitacoraContext = new LogAndBitacoraContext();

            return mapper.Map<List<BitacoraDto>>(bitacoraContext.GetBitacoras(skip, take));
        }

        public List<BitacoraDto> GetByEventType(EventTypeEnum eventType, int skip, int take)
        {
            var bitacoraContext = new LogAndBitacoraContext();

            return mapper.Map<List<BitacoraDto>>(bitacoraContext.GetBitacorasByEventType((int)eventType, skip, take));
        }

        public void Add(EventTypeEnum eventTypeEnum, string text, AdminUserDto adminUserDto)
        {
            try
            {
                var user = new AdminUsersContext().GetByKey(mapper.Map<AdminUsers>(adminUserDto).Key);

                if (user == null)
                    throw new Exception("Usuario no existente para ser agregado a la bitacora");

                var bitacora = new Bitacora()
                {
                    Text = text,
                    Type = new EnumContext().GetEventTypeByCode((int)eventTypeEnum),
                    User = user,
                    Date = DateTime.Now
                };

                new LogAndBitacoraContext().AddBitacora(bitacora);
            }
            catch (Exception)
            {
                LogHelper.Log(LogTypeCodeEnum.Error, "Error al intentar añadir un registro a la bitacora");
                throw;
            }
        }
    }
}
