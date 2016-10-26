using System.Data.SqlClient;
//using Model;
using EntityFramework.entityframework;
using DAL;

namespace Controller
{
    public class ControllerCustomer
    {

        public static Customer FindCustomer(SqlDataReader r)
        {
            Customer c = DALCustomer.FindCustomer(r);
            return c;
        }

        public static SqlCommand CreateCustomer(Customer c)
        {
            SqlCommand s = DALCustomer.CreateCustomer(c);
            return s;
        }

        public static SqlCommand DeleteCustomer(Customer c)
        {
            SqlCommand s = DALCustomer.DeleteCustomer(c);
            return s;
        }

        public static SqlCommand UpdateCustomer(Customer c)
        {
            SqlCommand s = DALCustomer.UpdateCustomer(c);
            return s;
        }

        public static SqlCommand FindCustomerCommand(string[] s)
        {
            SqlCommand cmd = DALCustomer.FindCustomerCommand(s);
            return cmd;
        }

        public static SqlCommand FindCustomerByPnrCommand(string[] s)
        {
            SqlCommand cmd = DALCustomer.FindCustomerByPnrCommand(s);
            return cmd;
        }
    }
}
