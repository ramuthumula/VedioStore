using System;
using System.Collections.Generic;
using VedioStoreDataLayer;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace VedioStoreDB
{
    public class TapeDB
    {
        static string SQLConnectionString = ConfigurationManager.ConnectionStrings["SQLConnectionString"].ConnectionString;

        //fetching the TapeId and Title form the Tape database, concating them and adding to a List.
        public static List<string> DropDown()
        {
            
            SqlConnection conn = null;
            SqlCommand command = null;
            List<string> list = new List<string>();
            try
            {
                conn = new SqlConnection(SQLConnectionString);
                conn.Open();
                command = new SqlCommand("select TapeId,Title from Tapes", conn);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(reader["TapeId"].ToString() + " " + reader["Title"].ToString());
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Sql Exception" + ex);
            }
            finally
            {
                conn.Close();
            }
            return list;

        }

        //Fetching the complete data form the tape Tabel and attaching to the DataTable.
        public static DataTable GridView()
        {
            SqlConnection conn = null;
            SqlCommand command = null;
            DataTable dt = null;
            try
            {
                conn = new SqlConnection(SQLConnectionString);
                dt = new DataTable();
                dt.Columns.Add(new DataColumn("TapeId", typeof(System.Int32)));
                dt.Columns.Add(new DataColumn("Title", typeof(System.String)));
                dt.Columns.Add(new DataColumn("Cost", typeof(System.String)));
                dt.Columns.Add(new DataColumn("RentalPrice", typeof(System.String)));
                dt.Columns.Add(new DataColumn("QuantityAvailable", typeof(System.String)));
                dt.Columns.Add(new DataColumn("QuantityRented", typeof(System.String)));
                conn.Open();
                command = new SqlCommand("select TapeId,Title,Cost,RentalPrice,QuantityAvailable,QuantityRented from Tapes", conn);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    DataRow datarow = dt.NewRow();
                    datarow["TapeId"] = reader["TapeId"];
                    datarow["Title"] = reader["Title"];
                    datarow["Cost"] = reader["Cost"];
                    datarow["RentalPrice"] = reader["RentalPrice"];
                    datarow["QuantityAvailable"] = reader["QuantityAvailable"];
                    datarow["QuantityRented"] = reader["QuantityRented"];
                    dt.Rows.Add(datarow);
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("sql Exception" + ex);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        //insert a record to tape tabel
        public static void Insert(Tapes data)
        {
            SqlConnection conn = null;
            SqlCommand command = null;
            try
            {
                conn = new SqlConnection(SQLConnectionString);
                conn.Open();
                command = new SqlCommand("insert into Tapes values(" + data.TapeId + ",'" + data.Title + "'," + data.Cost + "," + data.RentalPrice + "," + data.QuantityAvailable + "," + data.QuantityRented + ")", conn);
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("sql exception" + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        //fetching the details of particular Id and attaching to a list.
        public static List<string> GetDetailsById(int Id)
        {
            SqlConnection conn = null;
            SqlCommand command = null;
            List<string> list = new List<string>();
            try
            {
                conn = new SqlConnection(SQLConnectionString);
                conn.Open();
                command = new SqlCommand("select TapeId,Title,Cost,RentalPrice,QuantityAvailable,QuantityRented from Tapes where TapeId='" + Id + "'", conn);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(reader["TapeId"].ToString());
                    list.Add(reader["Title"].ToString());
                    list.Add(reader["Cost"].ToString());
                    list.Add(reader["RentalPrice"].ToString());
                    list.Add(reader["QuantityAvailable"].ToString());
                    list.Add(reader["QuantityRented"].ToString());
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Sql Exception" + ex);
            }
            finally
            {
                conn.Close();
            }
            return list;
        }

        //updating the record
        public static void Update(Tapes data)
        {
            SqlConnection conn = null;
            SqlCommand command = null;
            try
            {
                conn = new SqlConnection(SQLConnectionString);
                conn.Open();
                command = new SqlCommand("update Tapes set Title='" + data.Title + "', Cost=" + data.Cost + ",RentalPrice=" + data.RentalPrice + ",QuantityAvailable=" + data.QuantityAvailable + ",QuantityRented=" + data.QuantityRented + " where TapeId=" + data.TapeId, conn);
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        //Deleting the record form tape tabel
        public static void Delete(Tapes data)
        {
            SqlConnection conn = null;
            SqlCommand command = null;
            try
            {
                conn = new SqlConnection(SQLConnectionString);
                conn.Open();
                command = new SqlCommand("delete from Tapes where TapeId='" + data.TapeId + "'", conn);
                command.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();

            }
        }
    }
}
