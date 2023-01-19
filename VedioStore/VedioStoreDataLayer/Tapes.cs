using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VedioStoreDataLayer
{
    public class Tapes
    {
        public int TapeId { get; set; }
        public string Title { get; set; }
        public double Cost  { get; set; }
        public double RentalPrice  { get; set; }
        public int QuantityRented  { get; set; }
        public int QuantityAvailable { get; set; }
    }
}
