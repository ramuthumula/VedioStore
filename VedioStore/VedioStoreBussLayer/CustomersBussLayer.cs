using System;
using System.Collections.Generic;
using System.Data;
using VedioStoreDB;
using VedioStoreDataLayer;

namespace VedioStoreBussLayer
{
    public class CustomersBussLayer
    {
        //calling the DropDown function which return the list of concatenated string of CustId and CustName.
        public List<string> DropDown()
        {
            return CustomerDB.DropDown();
        }

        //returning the datatable 
        public DataTable GridView()
        {
            return CustomerDB.GridView();
        }

        //calling insert function in customerDb to insert the customer into customers table
        public void Insert(Customers data)
        {
            if (data.Phone.Length != 10)
            {
                throw new Exception("Invalid Phone Number");

            }
            else if (data.State.Length != 2)
            {
                throw new Exception("State Should Contain 2 characters only,please use state abbrivation's");
            }
            else
            {
                CustomerDB.Insert(data);
            }
            
        }
        //returning the customer details whose Id matches with Id parameter
        public List<string> GetDetailsById(int Id)
        {
            try
            {
                return CustomerDB.GetDetailsById(Id);
                
            }
            catch (Exception e)
            {
                throw new Exception("exception " + e);
            }

        }

        //calling the Update function in CustomerDb class and validating the phoneNo and State before calling the Update Function.
        public void Update(Customers data)
        {
            if (data.Phone.Length != 10)
            {
                throw new Exception("Invalid Phone Number");

            }

            else if (data.State.Length != 2)
            {
                throw new Exception("State Should Contain 2 characters only,please use state abbrivation's");
            }
            
            else
            {
                CustomerDB.Update(data);
            }
            

        }

        //calling the Delete function in CustomerDB class
        public void Delete(Customers data)
        {
            try
            {
                CustomerDB.Delete(data);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
