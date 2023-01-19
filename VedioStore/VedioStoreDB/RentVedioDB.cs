using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace VedioStoreDB
{
    public class RentVedioDB
    {
        static string SQLConnectionString = ConfigurationManager.ConnectionStrings["SQLConnectionString"].ConnectionString;

        //adds the rental to the rental tabel and adjust the QuantityAvailable and QuantityRented in Tapes Tabel.
        public static void Buy(int CustId, int TapeId, DateTime RentalDate, DateTime DueDate)
        {
            SqlConnection conn = null;
            SqlCommand command = null;
            DataTable dt = null;
       
            try
            {
                conn = new SqlConnection(SQLConnectionString);
                dt = new DataTable();
                conn.Open();
                command = new SqlCommand("BuyTape", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@TapeId", SqlDbType.Int).Value = TapeId;
                command.Parameters.Add("@CustId", SqlDbType.Int).Value = CustId;
                command.Parameters.Add("@RentalDate", SqlDbType.DateTime).Value = RentalDate;
                command.Parameters.Add("@DueDate", SqlDbType.DateTime).Value = DueDate;
                command.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                throw new Exception("sql Exception" + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        //checks the availability of the particular TapeId if available returns the count else returns 0
        public static int CheckAvailability(int TapeId)
        {
            SqlConnection conn = null;
            SqlCommand command = null;
            DataTable dt = null;
            int status = 0;
            try
            {
                conn = new SqlConnection(SQLConnectionString);
                dt = new DataTable();
                conn.Open();
                command = new SqlCommand("CheckAvailability", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@TapeId", SqlDbType.VarChar).Value = TapeId;
                status=Convert.ToInt32(command.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                throw new Exception("sql Exception" + ex);
            }
            finally
            {
                conn.Close();
            }
          
            return status;
        }
    }
}
