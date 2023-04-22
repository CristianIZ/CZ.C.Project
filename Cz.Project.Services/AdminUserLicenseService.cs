﻿using Cz.Project.Domain;
using Cz.Project.Dto;
using Cz.Project.SQLContext.Services;
using Cz.Project.SQLContext;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Cz.Project.Abstraction;

namespace Cz.Project.Services
{
    public class AdminUserLicenseService
    {
        public AdminUserLicenseDto GetLicensesByUser(string key)
        {
            var adminUserLicenses = new AdminUserLicenseContext().GetUserLicenses(key);

            if (adminUserLicenses == null)
                return null;

            var adminUser = new UserService().MapUser(adminUserLicenses.First().AdminUser);
            var licenses = new List<LicenseDto>();

            foreach (var userLicense in adminUserLicenses)
            {
                licenses.Add(new LicenseService().MapLicense(userLicense.Licenses));
            }

            return new AdminUserLicenseDto()
            {
                AdminUser = adminUser,
                Licenses = licenses
            };
        }

        public void SetPermissions(AdminUserLicenseDto adminUsersLicensesDto)
        {
            if (!adminUsersLicensesDto.Licenses.Any())
            {
                new AdminUserLicenseContext().DeleteByUser(new UserService().GetByKey(adminUsersLicensesDto.AdminUser.Key).Id);
            }
            else
            {
                var adminUserService = new UserService();
                var licenseService = new LicensesContext();

                var adminUserLicenseDomain = new List<AdminUserLicenses>();
                
                foreach (var lic in adminUsersLicensesDto.Licenses)
                {
                    adminUserLicenseDomain.Add(new AdminUserLicenses()
                    {
                        AdminUser = adminUserService.GetByKey(adminUsersLicensesDto.AdminUser.Key),
                        Licenses = licenseService.GetByCode(lic.LicenseCode)
                    });
                }

                var adminUserLicenseContext = new AdminUserLicenseContext();
                adminUserLicenseContext.AddRange(adminUserLicenseDomain);
            }
        }
    }
}
