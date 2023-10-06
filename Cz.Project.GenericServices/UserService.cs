using Cz.Project.Abstraction.Enums;
using Cz.Project.Domain;
using Cz.Project.Dto;
using Cz.Project.Abstraction.Exceptions;
using Cz.Project.GenericServices.UserSession;
using Cz.Project.SQLContext;
using System;
using System.Collections.Generic;
using System.Linq;
using Cz.Project.GenericServices.Helpers;
using AutoMapper;
using Cz.Project.SQLContext.Helpers;

namespace Cz.Project.GenericServices
{
    public class UserService
    {
        public IMapper mapper;

        public UserService()
        {
            var config = new AutoMapperProfiles();
            mapper = new Mapper(config.MapConfig());
        }

        public bool IsLoggedIn()
        {
            var session = Session.GetInstance();

            if (session.AdminUser != null)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Try to login user, if cant throws an error with detailed information
        /// </summary>
        public AdminUserDto Login(AdminUserDto user)
        {
            try
            {
                Session.Login(user);
                return Session.GetInstance().AdminUser;
            }
            catch (Exception ex)
            {
                LogHelper.Log(LogTypeCodeEnum.Error, ex.Message);
                throw;
            }
        }

        public IList<AdminUserDto> GetAll()
        {
            try
            {
                var adminUsersContext = new AdminUsersContext();
                return this.mapper.Map<IList<AdminUserDto>>(adminUsersContext.GetAll());
            }
            catch (Exception ex)
            {
                LogHelper.Log(LogTypeCodeEnum.Error, ex.Message);
                throw;
            }
        }

        public AdminUserDto GetByKeyDto(string key)
        {
            var adminUsersContext = new AdminUsersContext();
            var adminUser = adminUsersContext.GetByKey(key);

            return mapper.Map<AdminUserDto>(adminUser);
        }

        public AdminUsers GetByKey(string key)
        {
            try
            {
                var adminUsersContext = new AdminUsersContext();
                var adminUser = adminUsersContext.GetByKey(key);

                return adminUser;
            }
            catch (Exception ex)
            {
                LogHelper.Log(LogTypeCodeEnum.Error, ex.Message);
                throw;
            }
        }

        public AdminUserDto GetByName(string name)
        {
            try
            {
                return mapper.Map<AdminUserDto>(new AdminUsersContext().GetByName(name));
            }
            catch (Exception ex)
            {
                LogHelper.Log(LogTypeCodeEnum.Error, ex.Message);
                throw;
            }
        }

        public void Add(AdminUserDto adminUserDto)
        {
            try
            {
                ValidatePassword(adminUserDto);
                var adminUsersContext = new AdminUsersContext();

                var user = adminUsersContext.GetByName(this.mapper.Map<AdminUsers>(adminUserDto));
                if (user != null)
                    throw new CustomException("El usuario ya existe");

                adminUserDto.Password = HashHelper.Encrypt(adminUserDto.Password, HasAlgorithm.SHA512, null);
                adminUserDto.Key = Guid.NewGuid().ToString();
                adminUsersContext.Add(this.mapper.Map<AdminUsers>(adminUserDto));

                new BitacoraService().Add(Dto.Enums.EventTypeEnum.Data_modified, $"El usuario agrego un nuevo usuario con la key: {adminUserDto.Key}", adminUserDto);
                LogHelper.Log(LogTypeCodeEnum.Info, $"Se creo el usuario: {adminUserDto.Name} Key: {adminUserDto.Key} satisfactoriamente");
            }
            catch (Exception ex)
            {
                LogHelper.Log(LogTypeCodeEnum.Error, ex.Message);
                throw;
            }
        }

        public AdminUserDto Update(AdminUserDto selectedUser, AdminUserDto newUserValues)
        {
            try
            {
                ValidatePassword(newUserValues);
                newUserValues.Password = HashHelper.Encrypt(newUserValues.Password, HasAlgorithm.SHA512, null);

                var AdminUsersContext = new AdminUsersContext();
                var userToChange = AdminUsersContext.GetByName(this.mapper.Map<AdminUsers>(newUserValues));

                if (userToChange != null)
                    throw new CustomException("El usuario ya existe");

                var selectedUserData = AdminUsersContext.GetByKey(selectedUser.Key);
                new AdminUserHistoricalService().Add(selectedUserData.Key);

                userToChange = new AdminUsers()
                {
                    Id = selectedUserData.Id,
                    Name = newUserValues.Name,
                    Password = newUserValues.Password,
                    Key = selectedUser.Key,
                    CheckDigit = selectedUserData.CheckDigit
                };

                AdminUsersContext.Update(userToChange);

                new BitacoraService().Add(Dto.Enums.EventTypeEnum.Data_modified, $"Se edito el usuario con key: {selectedUser.Key}", selectedUser);
                LogHelper.Log(LogTypeCodeEnum.Info, $"El Usuario: {selectedUser.Name} Key: {selectedUser.Key} actualizo al Usuario: {newUserValues.Name} Key: {newUserValues.Key}");
                return this.mapper.Map<AdminUserDto>(userToChange);
            }
            catch (Exception ex)
            {
                LogHelper.Log(LogTypeCodeEnum.Error, ex.Message);
                throw;
            }
        }

        public void Delete(AdminUserDto selectedUser)
        {
            try
            {
                var AdminUsersContext = new AdminUsersContext();

                var adminUser = this.mapper.Map<AdminUsers>(selectedUser);
                var userToDelete = AdminUsersContext.GetByName(adminUser);
                AdminUsersContext.Delete(userToDelete);

                var userSession = Session.GetInstance().AdminUser;
                LogHelper.Log(LogTypeCodeEnum.Info, $"El Usuario: {userSession.Name} Key: {userSession.Key} Elimino al Usuario: {selectedUser.Name} Key: {selectedUser.Key}");
            }
            catch (Exception ex)
            {
                LogHelper.Log(LogTypeCodeEnum.Error, ex.Message);
                throw;
            }
        }

        private void ValidatePassword(AdminUserDto adminUserDto)
        {
            var passwordLength = adminUserDto.Password.Length;

            if (passwordLength > 20 || passwordLength < 8)
            {
                throw new CustomException("La contraseña debe tener entre 8 y 20 caracteres");
            }
        }
    }
}
