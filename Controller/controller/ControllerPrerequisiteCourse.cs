using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EntityFramework.entityframework;
using System.Data.SqlClient;
using System.Data;

namespace Controller
{
    public class ControllerPrerequisiteCourse
    {

        public static PrerequisiteCourse FindPrerequisiteCourse(SqlDataReader r)
        {
            PrerequisiteCourse pc = DALPrerequisiteCourse.FindPrerequisiteCourse(r);
            return pc;
        }

        public static SqlCommand CreatePrerequisiteCourse(PrerequisiteCourse pc)
        {
            SqlCommand cmd = DALPrerequisiteCourse.CreatePrerequisiteCourse(pc);
            return cmd;
        }

        public static SqlCommand DeletePrerequisiteCourse(PrerequisiteCourse pc)
        {
            SqlCommand cmd = DALPrerequisiteCourse.DeletePrerequisiteCourse(pc);
            return cmd;
        }

        public static SqlCommand FindPrerequisiteCourseCommand(string[] s)
        {
            SqlCommand cmd = DALPrerequisiteCourse.FindPrerequisiteCourseCommand(s);
            return cmd;
        }

    }
}
