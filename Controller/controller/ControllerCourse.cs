using System.Data.SqlClient;
//using Model;
using EntityFramework.entityframework;
using DAL;

namespace Controller
{
    public class ControllerCourse
    {

        public static Course FindCourse(SqlDataReader r)
        {
            Course c = DALCourse.FindCourse(r);
            return c;
        }

        public static SqlCommand CreateCourse(Course co)
        {
            SqlCommand s = DALCourse.CreateCourse(co);
            return s;
        }

        public static SqlCommand DeleteCourse(Course co)
        {
            SqlCommand s = DALCourse.DeleteCourse(co);
            return s;
        }

        public static SqlCommand UpdateCourse(Course co)
        {
            SqlCommand s = DALCourse.UpdateCourse(co);
            return s;
        }

        public static SqlCommand FindCourseCommand(string[] s)
        {
            SqlCommand cmd = DALCourse.FindCourseCommand(s);
            return cmd;
        }

        public static SqlCommand FindCourseByCodeCommand(string[] s)
        {
            SqlCommand cmd = DALCourse.FindCourseByCodeCommand(s);
            return cmd;
        }

        public static SqlCommand FindCourseByCoIdCommand(string[] s)
        {
            SqlCommand cmd = DALCourse.FindCourseByCoIdCommand(s);
            return cmd;
        }

    }
}
