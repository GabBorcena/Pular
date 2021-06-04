using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using EmployeeManagement.Models;

namespace EmployeeManagement.Repositories
{
    public class UserSettingsRepository
    {
        public EmployeeDetails GetEmployeeDetails(string userId)
        {
            string query = "[dbo].[GetUserInformation]";
            string[] paramValue = new string[] { "@pUserId" };
            string[] paramName = new string[] { userId };

            DataAccessHelper db = new DataAccessHelper();
            return db.GetData<EmployeeDetails>(query, paramValue, paramName, CommandType.StoredProcedure)[0];
        }

        public DataSet GetHomeEmployeeDetails(string userId)
        { 
            DataSet result = new DataSet();
            try
            {
                string query = "[dbo].[GetUserInformation]";

                SqlParameter[] parameters = new SqlParameter[] { 
                    new SqlParameter("@pUserId",userId)
                };

                DataAccessHelper db = new DataAccessHelper();
                result = db.GetData(query, parameters, CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

            }

            return result; 
        }
    }
}