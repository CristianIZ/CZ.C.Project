using AutoMapper;
using Cz.Project.Domain;
using Cz.Project.Dto;
using Cz.Project.Dto.Exceptions;
using Cz.Project.Repository;
using Cz.Project.Services.Helpers;
using Cz.Project.Services.UserSession;
using Cz.Project.SQLContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cz.Project.Services
{
    public class UserService
    {
        public bool IsLoggedIn()
        {
            var user = Session.GetInstance();

            if (user != null)
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
            catch (Exception)
            {
                throw;
            }
        }

        public IList<AdminUserDto> GetAll()
        {
            try
            {
                var adminUsersContext = new AdminUsersContext();
                return this.MapUsers(adminUsersContext.GetAll());
            }
            catch (Exception)
            {
                throw;
            }
        }

        public AdminUserDto GetByKeyDto(string key)
        {
            var adminUsersContext = new AdminUsersContext();
            var adminUser = adminUsersContext.GetByKey(key);

            return MapUser(adminUser);
        }

        public AdminUsers GetByKey(string key)
        {
            var adminUsersContext = new AdminUsersContext();
            var adminUser = adminUsersContext.GetByKey(key);

            return adminUser;
        }

        public void Add(AdminUserDto adminUserDto)
        {
            try
            {
                ValidatePassword(adminUserDto);

                var adminUsersContext = new AdminUsersContext();

                var user = adminUsersContext.GetByName(this.MapUser(adminUserDto));
                if (user != null)
                    throw new CustomException("El usuario ya existe");

                adminUserDto.Password = HashHelper.Encrypt(adminUserDto.Password, HasAlgorithm.SHA512, null);

                adminUsersContext.Add(this.MapUser(adminUserDto));
            }
            catch (Exception)
            {
                throw;
            }
        }

        public AdminUserDto Update(AdminUserDto currentUser, AdminUserDto newUserValues)
        {
            try
            {
                ValidatePassword(newUserValues);
                newUserValues.Password = HashHelper.Encrypt(newUserValues.Password, HasAlgorithm.SHA512, null);

                var AdminUsersContext = new AdminUsersContext();

                var userToChange = AdminUsersContext.GetByName(MapUser(newUserValues));

                if (userToChange != null)
                    throw new CustomException("El usuario ya existe");

                userToChange.Name = newUserValues.Name;
                userToChange.Password = newUserValues.Password;

                AdminUsersContext.Update(userToChange);

                return MapUser(userToChange);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Delete(AdminUserDto selectedUser)
        {
            var AdminUsersContext = new AdminUsersContext();
            
            var adminUser = MapUser(selectedUser);
            var userToDelete = AdminUsersContext.GetByName(adminUser);
            AdminUsersContext.Delete(userToDelete);
        }

        private void ValidatePassword(AdminUserDto adminUserDto)
        {
            var passwordLength = adminUserDto.Password.Length;

            if (passwordLength > 20 || passwordLength < 8)
            {
                throw new CustomException("La contraseña debe tener entre 8 y 20 caracteres");
            }
        }

        public AdminUsers MapUser(AdminUserDto adminUser)
        {
            return new AdminUsers()
            {
                Key = adminUser.Key,
                Name = adminUser.Name,
                Password = adminUser.Password
            };
        }

        public AdminUserDto MapUser(AdminUsers adminUser)
        {
            return new AdminUserDto()
            {
                Key = adminUser.Key,
                Name = adminUser.Name,
                Password = adminUser.Password
            };
        }

        public IList<AdminUsers> MapUsers(IList<AdminUserDto> adminUsers)
        {
            return adminUsers.Select(a => new AdminUsers()
            {
                Key = a.Key,
                Name = a.Name,
                Password = a.Password
            }).ToList();
        }

        public IList<AdminUserDto> MapUsers(IList<AdminUsers> adminUsers)
        {
            return adminUsers.Select(a => new AdminUserDto()
            {
                Key = a.Key,
                Name = a.Name,
                Password = a.Password
            }).ToList();
        }
    }
}
