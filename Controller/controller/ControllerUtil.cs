using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DAL;
using System.Data;

namespace Controller
{
    public class ControllerUtil
    {

        public static SqlConnection Connect()
        {
            SqlConnection conn = DALUtil.Connect();
            return conn;
        }

        public static List<Temp> FindAnything<Temp>(string[] identifier, Func<string[], SqlCommand> Test, Func<SqlDataReader, Temp> InputMethod)
        {
            List<Temp> returnlist = DALUtil.FindAnything(identifier, Test, InputMethod);
            return returnlist;
        }

        public static int CreateUpdateDeleteAnything<Temp>(Temp t, Func<Temp, SqlCommand> inputMethod)
        {
     
                int i = DALUtil.CreateUpdateDeleteAnything(t, inputMethod);
                return i;    
        
        }

        public static DataTable ListToTable<Temp>(List<Temp> list, DAL.DALUtil.Delegate1<Temp> InputMethod)
        {
            DataTable table = DALUtil.ListToTable(list, InputMethod);
            return table;
        }

        public static DataTable StatisticExecuter(string usp)
        {
            DataTable table = DALUtil.StatisticExecuter(usp);
            return table;
        }
    }
}
