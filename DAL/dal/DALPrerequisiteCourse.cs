using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFramework.entityframework;

namespace DAL
{
    public class DALPrerequisiteCourse
    {

        public static PrerequisiteCourse FindPrerequisiteCourse(SqlDataReader r)
        {
            PrerequisiteCourse pc = new PrerequisiteCourse();
            try
            {
                pc.coId = Decimal.ToInt32(r.GetDecimal(0));
                pc.prereqCoId = Decimal.ToInt32(r.GetDecimal(1));
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return pc;
        }

        public static SqlCommand CreatePrerequisiteCourse(PrerequisiteCourse pc)
        {
            SqlCommand cmd = new SqlCommand("usp_CreatePrerequisiteCourse");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@coId", SqlDbType.Decimal).Value = pc.coId;
            cmd.Parameters.Add("@prereqCoId", SqlDbType.Decimal).Value = pc.prereqCoId;
            return cmd;
        }

        public static SqlCommand DeletePrerequisiteCourse(PrerequisiteCourse pc)
        {
            SqlCommand cmd = new SqlCommand("usp_DeletePrerequisiteCourse");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@coId", SqlDbType.Decimal).Value = pc.coId;
            cmd.Parameters.Add("@prereqCoId", SqlDbType.Decimal).Value = pc.prereqCoId;
            return cmd;
        }

        public static SqlCommand FindPrerequisiteCourseCommand(string[] s)
        {
            SqlCommand cmd = new SqlCommand("usp_FindPrerequisiteCourse");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@coId", SqlDbType.Decimal).Value = s[0];
            return cmd;
        }


    }
}
