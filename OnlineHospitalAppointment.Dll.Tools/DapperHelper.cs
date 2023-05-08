using Dapper;
using System.Data.SqlClient;

namespace OnlineHospitalAppointment.Dll.Tools
{
    public static class DapperHelper
    {
        private static SqlConnection con;

        public static void Connection()
        {
            con = new SqlConnection(@"Server=.;Database=OnlineHospitalAppointmentDB;Trusted_Connection=True;");
        }

        public static int ExecuteNonQuery(string query, object param = null)
        {
            Connection();
            con.Open();
            int countRow = con.Execute(query, param);
            con.Close();

            return countRow;
        }

        public static T[] Query<T>(string query, object param = null)
        {
            Connection();
            con.Open();
            var result = con.Query<T>(query, param);
            con.Close();

            return result.ToArray();
        }

        public static T QueryFirstOrDefault<T>(string query, object param = null)
        {
            Connection();
            con.Open();
            var result = con.QueryFirstOrDefault<T>(query, param);
            con.Close();

            return result;
        }
    }
}