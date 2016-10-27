using System;
using System.Data;
using System.Data.SqlClient;
using EntityFramework.entityframework;
using System.Collections.Generic;

namespace DAL
{
    public class DALAttending
    {

        public static Attending FindAttending(SqlDataReader r)
        {
            Attending a = new Attending();
            try
            {
                a.agId = Decimal.ToInt32(r.GetDecimal(0));
                a.paid = r.GetString(1);
                a.course_coId = Decimal.ToInt32(r.GetDecimal(2));
                a.customer_cuId = Decimal.ToInt32(r.GetDecimal(3));
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return a;
        }

        public static SqlCommand CreateAttending(Attending a)
        {
            SqlCommand cmd = new SqlCommand("usp_CreateAttending");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@CoId", SqlDbType.VarChar).Value = a.course_coId;
            cmd.Parameters.Add("@CuId", SqlDbType.VarChar).Value = a.customer_cuId;
            cmd.Parameters.Add("@Paid", SqlDbType.VarChar).Value = a.paid;
            return cmd;
        }

        public static string CreateAttendingOLD(Attending a)
        {
            string s = "INSERT INTO Attending(paid,course_coId,customer_cuId) VALUES('" + a.paid + "','" + a.course_coId + "','" + a.customer_cuId + "');";
            return s;
        }

        public static SqlCommand DeleteAttending(Attending a)
        {
            SqlCommand cmd = new SqlCommand("usp_DeleteAttending");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@AgId", SqlDbType.VarChar).Value = a.agId;
            return cmd;
        }

        public static SqlCommand UpdateAttending(Attending a)
        {
            SqlCommand cmd = new SqlCommand("usp_UpdateAttending");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@CoId", SqlDbType.VarChar).Value = a.course_coId;
            cmd.Parameters.Add("@CuId", SqlDbType.VarChar).Value = a.customer_cuId;
            cmd.Parameters.Add("@Paid", SqlDbType.VarChar).Value = a.paid;
            return cmd;
        }

        public static SqlCommand FindAttendingByCustCommand(string[] s)
        {
            SqlCommand cmd = new SqlCommand("usp_FindAttendingByCust");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@CuId", SqlDbType.Int).Value = s[0];
            return cmd;
        }

        public static SqlCommand FindAttendingByCourCommand(string[] s)
        {
            SqlCommand cmd = new SqlCommand("usp_FindAttendingByCour");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@CoId", SqlDbType.Int).Value = s[0];
            return cmd;
        }

        public static SqlCommand FindAttendingByBothCommand(string[] s)
        {
            SqlCommand cmd = new SqlCommand("usp_FindAttendingByBoth");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Pnr", SqlDbType.VarChar).Value = s[0];
            cmd.Parameters.Add("@Code", SqlDbType.VarChar).Value = s[1];
            return cmd;
        }

        public static string[] TableCustAg(Attending a, ref string[] headers)
        {
            string cName = "";
            string cCode = "";
            string cPayed = "";
            if (a != null)
            {
                List<Course> courlist = DALUtil.FindAnything(new string[] { }, DALCourse.FindCourseCommand, DALCourse.FindCourse);
                foreach (Course c in courlist)
                {
                    if (a.course_coId == c.coId)
                    {
                        cName = c.name;
                        cCode = c.code;
                        cPayed = a.paid;
                    }
                }

            }
            string[] resultstring = { cName, cCode, cPayed };
            headers = new string[] { "Course", "Course code", "Pay date" };
            return resultstring;
        }

        public static string[] TableCourAg(Attending a, ref string[] headers)
        {
            string cName = "";
            string cPnr = "";
            string cPayed = "";
            if (a != null)
            {
                List<Customer> custlist = DALUtil.FindAnything(new string[] { }, DALCustomer.FindCustomerCommand, DALCustomer.FindCustomer);
                foreach (Customer c in custlist)
                {
                    if (a.customer_cuId == c.cuId)
                    {
                        cName = c.name;
                        cPnr = c.pnr;
                        cPayed = a.paid;
                    }
                }
            }
            string[] resultstring = { cName, cPnr, cPayed };
            headers = new string[] { "Name", "SSN", "Pay date" };
            return resultstring;
        }
    }
}
