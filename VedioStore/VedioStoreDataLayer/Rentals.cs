using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VedioStoreDataLayer
{
    public class Rentals
    {
        public int CustId { get; set; }
        public int TapeId { get; set; }
        public DateTime RentedDate { get; set; }
        public DateTime DueBack { get; set; }

    }
}
