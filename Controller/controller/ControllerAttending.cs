using System.Data.SqlClient;
//using Model;
using EntityFramework.entityframework;
using DAL;

namespace Controller
{
    public class ControllerAttending
    {

        public static Attending FindAttending(SqlDataReader r)
        {
            Attending a = DALAttending.FindAttending(r);
            return a;
        }

        public static SqlCommand CreateAttending(Attending a)
        {
            SqlCommand s = DALAttending.CreateAttending(a);
            return s;
        }

        public static string CreateAttendingOLD(Attending a)
        {
            string s = DALAttending.CreateAttendingOLD(a);
            return s;
        }

        public static SqlCommand DeleteAttending(Attending a)
        {
            SqlCommand s = DALAttending.DeleteAttending(a);
            return s;
        }

        public static SqlCommand UpdateAttending(Attending a)
        {
            SqlCommand s = DALAttending.UpdateAttending(a);
            return s;
        }

        public static SqlCommand FindAttendingByCustCommand(string[] s)
        {
            SqlCommand cmd = DALAttending.FindAttendingByCustCommand(s);
            return cmd;
        }

        public static SqlCommand FindAttendingByCourCommand(string[] s)
        {
            SqlCommand cmd = DALAttending.FindAttendingByCourCommand(s);
            return cmd;
        }

        public static SqlCommand FindAttendingByBothCommand(string[] s)
        {
            SqlCommand cmd = DALAttending.FindAttendingByBothCommand(s);
            return cmd;
        }

        public static string[] TableCustAg(Attending a, ref string[] headers)
        {
            string[] stringlist = DALAttending.TableCustAg(a, ref headers);
            return stringlist;
        }

        public static string[] TableCourAg(Attending a, ref string[] headers)
        {
            string[] stringlist = DALAttending.TableCourAg(a, ref headers);
            return stringlist;
        }

    }
}
