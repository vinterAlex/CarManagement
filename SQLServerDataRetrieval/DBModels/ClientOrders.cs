using System;
using System.Collections.Generic;

namespace CarManagement.DBModels
{
    public partial class ClientOrders
    {
        public int OrderId { get; set; }
        public int? PersonId { get; set; }
        public long? OrderPrice { get; set; }
        public string OrderName { get; set; }
        public string OrderDescription { get; set; }
        public DateTime? CreateDate { get; set; }
        public string ModifyUserId { get; set; }
        public long PurchasePrice { get; set; }

        public Persons Person { get; set; }
    }
}
