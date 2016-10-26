using System.Data.SqlClient;
using DAL;
//using Model;
using EntityFramework.entityframework;

namespace Controller
{
    public class ControllerAttended
    {
        public static Attended FindAttended(SqlDataReader r)
        {
            Attended c = DAL.DALAttended.FindAttended(r);
            return c;
        }

        public static SqlCommand CreateAttended(Attended a)
        {
            SqlCommand s = DAL.DALAttended.CreateAttended(a);
            return s;
        }

        public static SqlCommand DeleteAttended(Attended a)
        {
            SqlCommand s = DAL.DALAttended.DeleteAttended(a);
            return s;
        }

        public static SqlCommand UpdateAttended(Attended a)
        {
            SqlCommand s = DAL.DALAttended.UpdateAttended(a);
            return s;
        }

        public static SqlCommand FindAttendedByCustCommand(string[] s)
        {
            SqlCommand cmd = DALAttended.FindAttendedByCustCommand(s);
            return cmd;
        }

        public static SqlCommand FindAttendedByCourCommand(string[] s)
        {
            SqlCommand cmd = DALAttended.FindAttendedByCourCommand(s);
            return cmd;
        }

        public static SqlCommand FindAttendedByBothCommand(string[] s)
        {
            SqlCommand cmd = DALAttended.FindAttendedByBothCommand(s);
            return cmd;
        }

        public static string[] TableCustAd(Attended a, ref string[] headers)
        {
            string[] stringlist = DALAttended.TableCustAd(a, ref headers);
            return stringlist;
        }

        public static string[] TableCourAd(Attended a, ref string[] headers)
        {
            string[] stringlist = DALAttended.TableCourAd(a, ref headers);
            return stringlist;
        }
       
    }
}
