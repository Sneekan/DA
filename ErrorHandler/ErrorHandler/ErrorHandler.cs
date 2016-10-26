using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ErrorHandler
{

    public static class ErrorHandler
    {
        public static string HandleExceptions(Exception ex)
        {

            if (ex is SqlException)
            {
                return ex.Message;
            }
            else if (ex is ArgumentNullException)
            {
                return "Please make a selection first";
            }
            else if (ex is InvalidOperationException)
            {
                return "Invalid operation, no record was found";
            }
            else if (ex is NullReferenceException)
            {
                return "No record was found";
            }
            return "Your request could not be executed";
        }
    }

}
