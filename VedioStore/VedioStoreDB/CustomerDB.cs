using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using VedioStoreDataLayer;

namespace VedioStoreDB
{
    public class CustomerDB
    {
        static string SQLConnectionString = ConfigurationManager.ConnectionStrings["SQLConnectionString"].ConnectionString;

        //fetching the CustId and CustName form the Tape database, concating them and adding to a List.
        public static List<string> DropDown()
        {
            SqlConnection conn = null;
            SqlCommand command = null;
            List<string> list = new List<string>();
            try
            {
                conn = new SqlConnection(SQLConnectionString);
                conn.Open();
                command = new SqlCommand("select CustId,CustName from Customers", conn);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(reader["CustId"].ToString()+" "+reader["CustName"].ToString());
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

        //Fetching the complete data form Customers Table and storing in datatable
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
                dt.Columns.Add(new DataColumn("CustAddress", typeof(System.String)));
                dt.Columns.Add(new DataColumn("City", typeof(System.String)));
                dt.Columns.Add(new DataColumn("state", typeof(System.String)));
                dt.Columns.Add(new DataColumn("Zip", typeof(System.String)));
                dt.Columns.Add(new DataColumn("Phone", typeof(System.String)));
                conn.Open();
                command = new SqlCommand("select CustId,CustName,CustAddress,City,state,Zip,Phone from Customers", conn);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    DataRow datarow = dt.NewRow();
                    datarow["CustId"] = reader["CustId"];
                    datarow["CustName"] = reader["CustName"];
                    datarow["CustAddress"] = reader["CustAddress"];
                    datarow["City"] = reader["City"];
                    datarow["state"] = reader["state"];
                    datarow["Zip"] = reader["Zip"];
                    datarow["Phone"] = reader["Phone"];
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

        //Inserting a record to customers table
        public static void Insert(Customers data)
        {
            SqlConnection conn = null;
            SqlCommand command = null;
            try
            {
                conn = new SqlConnection(SQLConnectionString);
                conn.Open();
                command = new SqlCommand("insert into Customers values(" + data.CustId + ",'" + data.CustName + "','" + data.CustAddress + "','" + data.City + "','" + data.State + "','" + data.Zip + "','"+data.Phone+"','"+data.MemberSince+"')", conn);
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

        //getting the details for the customer whose Custid match with the ID parameter
        public static List<string> GetDetailsById(int Id)
        {
            SqlConnection conn = null;
            SqlCommand command = null;
            List<string> list = new List<string>();
            try
            {
                conn = new SqlConnection(SQLConnectionString);
                conn.Open();
                command = new SqlCommand("select CustId,CustName,CustAddress,City,state,Zip,Phone,MemberSince from Customers where CustId='" + Id + "'", conn);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(reader["CustId"].ToString());
                    list.Add(reader["CustName"].ToString());
                    list.Add(reader["CustAddress"].ToString());
                    list.Add(reader["City"].ToString());
                    list.Add(reader["State"].ToString());
                    list.Add(reader["Zip"].ToString());
                    list.Add(reader["Phone"].ToString());
                    list.Add(reader["MemberSince"].ToString());
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

        //updating the customer data
        public static void Update(Customers data)
        {
            SqlConnection conn = null;
            SqlCommand command = null;
            try
            {
                conn = new SqlConnection(SQLConnectionString);
                conn.Open();
                command = new SqlCommand("update Customers set CustName='" + data.CustName + "', CustAddress='" + data.CustAddress + "',City='" + data.City + "',state='" + data.State + "',Zip='" + data.Zip + "',Phone='"+data.Phone+"',MemberSince='"+data.MemberSince+"' where CustId=" + data.CustId, conn);
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

        //deleting the particular data
        public static void Delete(Customers data)
        {
            SqlConnection conn = null;
            SqlCommand command = null;
            try
            {
                conn = new SqlConnection(SQLConnectionString);
                conn.Open();
                command = new SqlCommand("delete from Customers where CustId='" + data.CustId + "'", conn);
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
