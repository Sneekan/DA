using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
//using ErrorHandler;

namespace DAL
{
    public class DALUtil
    {

        public delegate string[] Delegate1<Temp>(Temp t, ref string[] headers);

        public static SqlConnection Connect()
        {
            string connsting = SqlString.joels2;
            SqlConnection conn = new SqlConnection(connsting);
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return conn;
        }

        public static List<Temp> FindAnything<Temp>(string[] identifier, Func<string[], SqlCommand> Test, Func<SqlDataReader, Temp> InputMethod)
        {
            SqlDataReader myReader = null;
            List<Temp> resultlist = new List<Temp>();
            SqlConnection conn = Connect();
            if (conn == null)
                return null;
            SqlCommand mySqlCommand = Test(identifier);
            mySqlCommand.Connection = conn;
            try
            {
                myReader = mySqlCommand.ExecuteReader();
                while (myReader.Read()) //Loopen
                {
                    if (myReader.GetValue(0) != DBNull.Value) //Kontrollen (optimal)
                    {
                        Temp t = InputMethod(myReader);
                        resultlist.Add(t);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (myReader != null)
                    myReader.Close();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            Console.WriteLine("DONE");
            return resultlist;
        }

        public static int CreateUpdateDeleteAnything<Temp>(Temp t, Func<Temp, SqlCommand> InputMethod)
        {
            SqlConnection conn = Connect();
            int i = 0;
            if (conn == null)
                return 0;
            try
            {
                SqlCommand mySqlCommand = InputMethod(t);
                mySqlCommand.Connection = conn;
                i = mySqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            return i;
        }

        public static DataTable ListToTable<Temp>(List<Temp> list, Delegate1<Temp> InputMethod)
        {
            DataTable table = new DataTable();
            string[] headers = new string[0];
            int columns = 3;

            try
            {
                Temp t1 = default(Temp);
                if (list.Count() != 0)
                {

                    //Hämta header
                    columns = InputMethod(t1, ref headers).Length; //längden på listan


                    for (int i = 0; i < columns; i++)
                    {
                        table.Columns.Add(headers[i]);
                    }
                    foreach (Temp t2 in list)
                    {
                        //Hämta en rad i tablen
                        string[] stringlist = InputMethod(t2, ref headers);
                        table.Rows.Add(stringlist);
                    }
                }
                else
                {
                    InputMethod(t1, ref headers);
                    for (int i = 0; i < headers.Length; i++)
                        table.Columns.Add(headers[i]);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return table;
        }

        public static DataTable StatisticExecuter(string usp)
        {
            DataTable table = new DataTable();
            try
            {
                using (var con = Connect())
                using (var cmd = new SqlCommand(usp, con))
                using (var da = new SqlDataAdapter(cmd))
                {
                    da.Fill(table);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return table;

        }

    }
}