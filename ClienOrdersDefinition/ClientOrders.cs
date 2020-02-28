using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientOrdersDefinition
{
    public class ClientOrders
    {
        public int OrderId { get; set; }
        public int PersonID { get; set; }
        public Int64 OrderPrice { get; set; }
        public string OrderName { get; set; }
        public string OrderDescription { get; set; }
        public DateTime CreateDate { get; set; }
        public int ModifyUserID { get; set; }
        public Int64 PurchasePrice { get; set; }

    }
}
