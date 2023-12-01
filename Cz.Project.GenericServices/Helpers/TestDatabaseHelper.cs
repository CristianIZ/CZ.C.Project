using Cz.Project.SQLContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cz.Project.GenericServices.Helpers
{
    public static class TestDatabaseHelper
    {
        public static bool IsDatabaseCreated()
        {
            try
            {
                new SQLDataAccess().OpenConnection();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            } 
        }

        public static void CreateDatabase()
        {
            new SQLCreation().Create();
        }
    }
}
