using Cz.Project.Abstraction.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cz.Project.SQLContext.Helpers
{
    public static class SecurityDigitHelper
    {
        public static void CompareDataIntegrity(string columnVerificationDigit, IList<string> columnDataList)
        {
            if (columnVerificationDigit == null)
                return;

            var generatedDigit = GenerateSecurityColumnDigit(columnDataList);

            if (columnVerificationDigit != generatedDigit)
            {
                throw new ColumnModificationException("Columna modificada manualmente");
            }
        }

        public static string GenerateSecurityColumnDigit(IList<string> data)
        {
            var orderedInput = string.Join("", data.OrderBy(x => x).ToList());
            return SecurityLogicToEncrypt(orderedInput);
        }

        public static string SecurityLogicToEncrypt(string codeToEncrypt)
        {
            int numericValue = 0;

            foreach (var item in codeToEncrypt)
            {
                numericValue += item;
            }

            return CryptographyHelper.Encrypt(numericValue.ToString());
        }
    }
}
