using System;
using System.Data;
using System.Data.SqlClient;
//using Model;
using EntityFramework.entityframework;

namespace DAL
{
    public class DALCustomer
    {

        public static Customer FindCustomer(SqlDataReader r)
        {
            Customer c = new Customer();
            try
            {
                c.cuId = Decimal.ToInt32(r.GetDecimal(0));
                c.address = r.GetString(1);
                c.mail = r.GetString(2);
                c.name = r.GetString(3);
                c.phonenr = r.GetString(4);
                c.pnr = r.GetString(5);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return c;
        }

        public static SqlCommand CreateCustomer(Customer c)
        {
            SqlCommand cmd = new SqlCommand("usp_CreateCustomer");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Pnr", SqlDbType.VarChar).Value = c.pnr;
            cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = c.name;
            cmd.Parameters.Add("@Address", SqlDbType.VarChar).Value = c.address;
            cmd.Parameters.Add("@Phonenr", SqlDbType.VarChar).Value = c.phonenr;
            cmd.Parameters.Add("@Mail", SqlDbType.VarChar).Value = c.mail;
            return cmd;
        }

        public static SqlCommand DeleteCustomer(Customer c)
        {
            SqlCommand cmd = new SqlCommand("usp_DeleteCustomer");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Pnr", SqlDbType.VarChar).Value = c.pnr;
            return cmd;
        }

        public static SqlCommand UpdateCustomer(Customer c)
        {
            SqlCommand cmd = new SqlCommand("usp_UpdateCustomer");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Pnr", SqlDbType.VarChar).Value = c.pnr;
            cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = c.name;
            cmd.Parameters.Add("@Address", SqlDbType.VarChar).Value = c.address;
            cmd.Parameters.Add("@Phonenr", SqlDbType.VarChar).Value = c.phonenr;
            cmd.Parameters.Add("@Mail", SqlDbType.VarChar).Value = c.mail;
            return cmd;
        }

        public static SqlCommand FindCustomerCommand(string[] s)
        {
            SqlCommand cmd = new SqlCommand("usp_FindCustomer");
            cmd.CommandType = CommandType.StoredProcedure;
            return cmd;
        }

        public static SqlCommand FindCustomerByPnrCommand(string[] s)
        {
            SqlCommand cmd = new SqlCommand("usp_FindCustomerByPnr");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Pnr", SqlDbType.VarChar).Value = s[0];
            return cmd;
        }
        public static SqlCommand FindCustomerCountAttending(string[] s)
        {
            SqlCommand cmd = new SqlCommand("usp_StatParticipant");
            cmd.CommandType = CommandType.StoredProcedure;
            return cmd;
        }
    }
}
