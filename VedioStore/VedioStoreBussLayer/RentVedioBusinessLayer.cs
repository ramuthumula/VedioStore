using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VedioStoreDB;

namespace VedioStoreBussLayer
{
    public class RentVedioBusinessLayer
    {
        public void RentVedio(int CustId,int TapeId,DateTime RentalDate, DateTime DueDate)
        {
            if (RentalDate > DueDate)    //DueDate cannot be prior to the rentalDate
            {
                throw new Exception("DueDate Cannot be greater than the Rental Date");
            }
            else
            {
                if (RentVedioDB.CheckAvailability(TapeId) != 0)  // checking the Tape availabilily for that TapeId. if tape are availabe CheckAvailibility function return the count of tapes else return 0
                {
                    RentVedioDB.Buy(CustId, TapeId, RentalDate, DueDate);  // if Tape are available the we can rent the tape.
                }
                else
                {
                    throw new Exception("Tapes Not available to Rent");
                }
            }

        }
        //return the list of CustId and CustName.
        public List<string> LoadCustomers()
        {
           return CustomerDB.DropDown();
            
        }

        //return the List of Tapeid and Title 
        public List<string> LoadTapes()
        {
           return TapeDB.DropDown();
        }
    }
}
