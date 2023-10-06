using System;
using System.Collections.Generic;
using System.Text;

namespace Cz.Project.SQLContext.Enums
{
    public static class TableAndColumnNamesEnum
    {
        public static readonly string AdminUserTable = "AdminUsers";
        public static readonly string AdminUserTableCheckDigitColumn = "CheckDigit";
        public static readonly string AdminUserTableNameColumn = "Name";
        public static readonly string AdminUserTablePasswordColumn = "Password";
        public static readonly string AdminUserTableKeyColumn = "Key";

        public static readonly string DigitColumnVerificationsTable = "DigitColumnVerifications";

        public static readonly string AdminUserLicensesTable = "AdminUserLicenses";
        public static readonly string LanguajesTable = "Languajes";
    }
}
