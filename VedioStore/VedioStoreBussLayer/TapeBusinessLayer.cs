using System;
using System.Collections.Generic;
using VedioStoreDB;
using VedioStoreDataLayer;
using System.Data;

namespace VedioStoreBussLayer
{
    
    public  class TapeBusinessLayer
    {
        //returning all the Tapes and TapeId that we got from the Database
        public List<string> DropDown()
        {
            return TapeDB.DropDown();
        }

        // returning all the data available in Tape database
        public DataTable GridView()
        {
            return TapeDB.GridView();
        }

        //Calling the Insert function in TapeDB
        public void Insert(Tapes data)
        {

                TapeDB.Insert(data);

        }

        //returnign the record fetched from database for the Particular TapeId
        public List<string> GetDetailsById(int Id)
        {
            try
            {
                return TapeDB.GetDetailsById(Id);

            }
            catch (Exception e)
            {
                throw new Exception("exception " + e);
            }

        }

        //calling the Update Function in TapeDB
        public void Update(Tapes data)
        {
                TapeDB.Update(data);

        }
        //calling the Delete function in TapeDB
        public void Delete(Tapes data)
        {
            try
            {
                TapeDB.Delete(data);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
