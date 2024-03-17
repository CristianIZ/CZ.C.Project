using Cz.Project.Abstraction.Exceptions;
using Cz.Project.Domain;
using Cz.Project.Dto;
using Cz.Project.SQLContext;
using Cz.Project.SQLContext.Enums;
using Cz.Project.SQLContext.Helpers;
using Cz.Project.SQLContext.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cz.SecurityColumGenerator
{
    public class AdminUserIntegrity
    {
        public string CheckAllRowsIntegrity(bool fixRow)
        {
            var adminUserContext = new AdminUsersContext();
            var adminUsers = adminUserContext.GetAll();
            var adminUsersToFix = new List<AdminUsers>();
            var damagedRowQuantity = 0;

            foreach (var adminUser in adminUsers)
            {
                try
                {
                    adminUserContext.CheckRowIntegrity(adminUser);
                }
                catch (Exception ex)
                {
                    damagedRowQuantity++;
                }

                if (fixRow)
                {
                    adminUsersToFix.Add(adminUser);
                }
            }

            foreach (var adminUser in adminUsersToFix)
            {
                var checkDigit = SecurityDigitHelper.SecurityLogicToEncrypt($"{adminUser.Name}{adminUser.Password}{adminUser.Key}");
                adminUser.CheckDigit = checkDigit;

                adminUserContext.Update(adminUser);
            }

            return $"Total damaged rows = {damagedRowQuantity} / {adminUsers.Count}";
        }

        public string EncryptPassword(string password)
        {
            return HashHelper.Encrypt(password, HasAlgorithm.SHA512, null);
        }

        public string CheckTableIntegrity()
        {
            try
            {
                new AdminUsersContext().CheckTableIntegrity();
                return "All fine";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string GenerateTableVerificationDigit()
        {
            try
            {
                new AdminUsersContext().GenerateTableVerificationDigit();
                return "Table fixed";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
