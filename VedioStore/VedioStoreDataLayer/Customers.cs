using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VedioStoreDataLayer
{
    public class Customers
    {
        public int CustId { get; set; }
        public string CustName { get; set; }
        public string CustAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip{   get; set; }
        public string Phone { get; set; }
        public DateTime MemberSince { get; set; }

    }
}
