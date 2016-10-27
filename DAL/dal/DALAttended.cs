using System;
using System.Data;
using System.Data.SqlClient;
using EntityFramework.entityframework;
using System.Collections.Generic;

namespace DAL
{
    public class DALAttended
    {

        public static Attended FindAttended(SqlDataReader r)
        {
            Attended a = new Attended();
            try
            {
                a.adId = Decimal.ToInt32(r.GetDecimal(0));
                a.grade = r.GetString(1);
                a.course_coId = Decimal.ToInt32(r.GetDecimal(2));
                a.customer_cuId = Decimal.ToInt32(r.GetDecimal(3));
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return a;
        }

        public static SqlCommand CreateAttended(Attended a)
        {
            SqlCommand cmd = new SqlCommand("usp_CreateAttended");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@CoId", SqlDbType.VarChar).Value = a.course_coId;
            cmd.Parameters.Add("@CuId", SqlDbType.VarChar).Value = a.customer_cuId;
            cmd.Parameters.Add("@Grade", SqlDbType.VarChar).Value = a.grade;
            return cmd;
        }

        public static SqlCommand DeleteAttended(Attended a)
        {
            SqlCommand cmd = new SqlCommand("usp_DeleteAttended");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@AdId", SqlDbType.VarChar).Value = a.adId;
            return cmd;
        }

        public static SqlCommand UpdateAttended(Attended a)
        {
            SqlCommand cmd = new SqlCommand("usp_UpdateAttended");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@CoId", SqlDbType.VarChar).Value = a.course_coId;
            cmd.Parameters.Add("@CuId", SqlDbType.VarChar).Value = a.customer_cuId;
            cmd.Parameters.Add("@Grade", SqlDbType.VarChar).Value = a.grade;
            return cmd;
        }

        public static SqlCommand FindAttendedByCustCommand(string[] s)
        {
            SqlCommand cmd = new SqlCommand("usp_FindAttendedByCust");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@CuId", SqlDbType.Int).Value = s[0];
            return cmd;
        }

        public static SqlCommand FindAttendedByCourCommand(string[] s)
        {
            SqlCommand cmd = new SqlCommand("usp_FindAttendedByCour");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@CoId", SqlDbType.Int).Value = s[0];
            return cmd;
        }

        public static SqlCommand FindAttendedByBothCommand(string[] s)
        {
            SqlCommand cmd = new SqlCommand("usp_FindAttendedByBoth");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Pnr", SqlDbType.VarChar).Value = s[0];
            cmd.Parameters.Add("@Code", SqlDbType.VarChar).Value = s[1];
            return cmd;
        }

        public static string[] TableCustAd(Attended a, ref string[] headers)
        {
            string cName = "";
            string cCode = "";
            string cGrade = "";
            if (a != null)
            {
                List<Course> courlist = DALUtil.FindAnything(new string[] { }, DALCourse.FindCourseCommand, DALCourse.FindCourse);
                foreach (Course c in courlist)
                {
                    if (c.coId == a.course_coId)
                    {
                        cName = c.name;
                        cCode = c.code;
                        cGrade = a.grade;
                    }
                }
            }
            string[] resultstring = { cName, cCode, cGrade };
            headers = new string[] { "Course", "Course code", "Grade" };
            return resultstring;
        }

        public static string[] TableCourAd(Attended a, ref string[] headers)
        {
            string cName = "";
            string cPnr = "";
            string cGrade = "";
            if (a != null)
            {
                List<Customer> custlist = DALUtil.FindAnything(new string[] { }, DALCustomer.FindCustomerCommand, DALCustomer.FindCustomer);
                foreach (Customer c in custlist)
                {
                    if (a.customer_cuId == c.cuId)
                    {
                        cName = c.name;
                        cPnr = c.pnr;
                        cGrade = a.grade;
                    }
                }
            }
            string[] resultstring = { cName, cPnr, cGrade };
            headers = new string[] { "Name", "SSN", "Grade" };
            return resultstring;
        }
    }
}
