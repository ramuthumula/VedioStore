using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace VedioStoreDB
{
    public  class RentalsDB
    {
        static string SQLConnectionString = ConfigurationManager.ConnectionStrings["SQLConnectionString"].ConnectionString;
        //returns the list of customers
        public static List<string> DropDown()
        {
            SqlConnection conn = null;
            SqlCommand command = null;
            List<string> list = new List<string>();
            try
            {
                conn = new SqlConnection(SQLConnectionString);
                conn.Open();
                command = new SqlCommand("GetCustomers", conn);
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(reader["CustName"].ToString());
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

        //returns the complete Rental table as datatable
        public static DataTable GridView()
        {
            SqlConnection conn = null;
            SqlCommand command = null;
            DataTable dt = null;
            try
            {
                conn = new SqlConnection(SQLConnectionString);
                dt = new DataTable();
                dt.Columns.Add(new DataColumn("CustId", typeof(System.Int32)));
                dt.Columns.Add(new DataColumn("CustName", typeof(System.String)));
                dt.Columns.Add(new DataColumn("TapeId", typeof(System.Int32)));
                dt.Columns.Add(new DataColumn("Title", typeof(System.String)));
                conn.Open();
                command = new SqlCommand("GetAllRentals", conn);
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    DataRow datarow = dt.NewRow();
                    datarow["CustId"] = reader["CustId"];
                    datarow["CustName"] = reader["CustName"];
                    datarow["TapeId"] = reader["TapeId"];
                    datarow["Title"] = reader["Title"];
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

        //return the datatable of Rental of the particular customer.
        public static DataTable GridViewSortByName(string Name)
        {
            SqlConnection conn = null;
            SqlCommand command = null;
            DataTable dt = null;
            try
            {
                conn = new SqlConnection(SQLConnectionString);
                dt = new DataTable();
                dt.Columns.Add(new DataColumn("CustId", typeof(System.Int32)));
                dt.Columns.Add(new DataColumn("CustName", typeof(System.String)));
                dt.Columns.Add(new DataColumn("TapeId", typeof(System.Int32)));
                dt.Columns.Add(new DataColumn("Title", typeof(System.String)));
                conn.Open();
                command = new SqlCommand("GetNamedRentals", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@Name", SqlDbType.VarChar).Value = Name;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    DataRow datarow = dt.NewRow();
                    datarow["CustId"] = reader["CustId"];
                    datarow["CustName"] = reader["CustName"];
                    datarow["TapeId"] = reader["TapeId"];
                    datarow["Title"] = reader["Title"];
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

        }
}
