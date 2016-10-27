using System;
using System.Data;
using System.Data.SqlClient;
//using Model;
using EntityFramework.entityframework;

namespace DAL
{
    public class DALCourse
    {

        public static Course FindCourse(SqlDataReader r)
        {
            Course c = new Course();
            try
            {
                c.coId = Decimal.ToInt32(r.GetDecimal(0));
                c.code = r.GetString(1);
                c.inactive = r.GetString(2);
                c.name = r.GetString(3);
                c.price = r.GetInt32(4);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return c;
        }

        public static SqlCommand CreateCourse(Course c)
        {
            SqlCommand cmd = new SqlCommand("usp_CreateCourse");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Code", SqlDbType.VarChar).Value = c.code;
            cmd.Parameters.Add("@Inactive", SqlDbType.VarChar).Value = c.inactive;
            cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = c.name;
            cmd.Parameters.Add("@Price", SqlDbType.VarChar).Value = c.price;
            return cmd;
        }

        public static SqlCommand DeleteCourse(Course c)
        {
            SqlCommand cmd = new SqlCommand("usp_DeleteCourse");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Code", SqlDbType.VarChar).Value = c.code;
            return cmd;
        }

        public static SqlCommand UpdateCourse(Course c)
        {
            SqlCommand cmd = new SqlCommand("usp_UpdateCourse");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Code", SqlDbType.VarChar).Value = c.code;
            cmd.Parameters.Add("@Inactive", SqlDbType.VarChar).Value = c.inactive;
            cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = c.name;
            cmd.Parameters.Add("@Price", SqlDbType.VarChar).Value = c.price;
            return cmd;
        }

        public static SqlCommand FindCourseCommand(string[] s)
        {
            SqlCommand cmd = new SqlCommand("usp_FindCourse");
            cmd.CommandType = CommandType.StoredProcedure;
            return cmd;
        }

        public static SqlCommand FindCourseByCodeCommand(string[] s)
        {
            SqlCommand cmd = new SqlCommand("usp_FindCourseByCode");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Code", SqlDbType.VarChar).Value = s[0];
            return cmd;
        }

        public static SqlCommand FindCourseByCoIdCommand(string[] s)
        {
            SqlCommand cmd = new SqlCommand("usp_FindCourseByCoId");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@coId", SqlDbType.VarChar).Value = s[0];
            return cmd;
        }
    }
}