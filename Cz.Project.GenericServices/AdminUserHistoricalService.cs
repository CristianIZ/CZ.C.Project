using AutoMapper;
using Cz.Project.Abstraction.Enums;
using Cz.Project.Domain;
using Cz.Project.Dto;
using Cz.Project.GenericServices.Helpers;
using Cz.Project.SQLContext;
using Cz.Project.SQLContext.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cz.Project.GenericServices
{
    public class AdminUserHistoricalService
    {
        public IMapper mapper;

        public AdminUserHistoricalService()
        {
            var config = new AutoMapperProfiles();
            mapper = new Mapper(config.MapConfig());
        }

        public void Add(string adminUserKey)
        {
            try
            {
                var adminUser = new AdminUsersContext().GetByKey(adminUserKey);
                new AdminUserHistoricalContext().Add(adminUser);
                LogHelper.Log(LogTypeCodeEnum.Info, $"Se creo el usuario historico userid: {adminUser.Id}");
            }
            catch (Exception ex)
            {
                LogHelper.Log(LogTypeCodeEnum.Error, ex.Message);
                throw;
            }
        }

        public AdminUserHistorical GetById(int id)
        {
            var historicalDto = new AdminUserHistoricalContext().GetById(id);
            historicalDto.User = new AdminUsersContext().GetById(historicalDto.UserId.Value);

            return historicalDto;
        }

        public void RecoverUser(AdminUserDto userDto, AdminUserHistoricalDto historicalDto)
        {
            try
            {
                var historicalUser = this.GetById(historicalDto.Id);

                var userToRecover = new AdminUsersContext().GetByKey(userDto.Key);
                userToRecover.Name = historicalUser.Name;
                userToRecover.Password = historicalUser.Password;
                userToRecover.CheckDigit = historicalUser.CheckDigit;

                // TODO: Deberia haber una transaccion
                new AdminUsersContext().Update(userToRecover);
                new AdminUserHistoricalContext().DeleteSince(historicalUser);

                new BitacoraService().Add(Dto.Enums.EventTypeEnum.Data_modified, "Se recupero el usuario historico", userDto);
                LogHelper.Log(LogTypeCodeEnum.Info, $"Se recupero el usuario historico: {userDto.Name}");
            }
            catch (Exception ex)
            {
                LogHelper.Log(LogTypeCodeEnum.Error, ex.Message);
                throw;
            }
        }

        public List<AdminUserHistoricalDto> GetByAdminUser(string adminUserKey)
        {
            try
            {
                var adminUser = new AdminUsersContext().GetByKey(adminUserKey);
                var adminHistoricals = new AdminUserHistoricalContext().GetByUserId(adminUser);

                return mapper.Map<List<AdminUserHistoricalDto>>(adminHistoricals);
            }
            catch (Exception ex)
            {
                LogHelper.Log(LogTypeCodeEnum.Error, ex.Message);
                throw;
            }
        }
    }
}
