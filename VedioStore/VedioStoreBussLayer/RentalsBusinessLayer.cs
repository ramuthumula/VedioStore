using System;
using System.Collections.Generic;
using VedioStoreDataLayer;
using VedioStoreDB;
using System.Data;

namespace VedioStoreBussLayer
{
    public class RentalsBusinessLayer
    {
        //return the list of CustNames
        public List<string> DropDown()
        {
            return RentalsDB.DropDown();
        }

        //returns the datatable of the Rental table in database.
        public DataTable GridView()
        {
            return RentalsDB.GridView();
        }

        //returns the filtered datatable for the particular name.
        public DataTable GridViewSoryByName(string Name)
        {
            return RentalsDB.GridViewSortByName(Name);
        }
    }
}
