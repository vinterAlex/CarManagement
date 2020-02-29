using System;
using System.Collections.Generic;

namespace CarManagement.Models
{
    public partial class Persons
    {
        public Persons()
        {
            ClientOrders = new HashSet<ClientOrders>();
        }

        public int PersonId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public int CountryId { get; set; }
        public string City { get; set; }
        public DateTime? CreateDate { get; set; }
        public long? VehicleId { get; set; }
        public long? OrderId { get; set; }

        public Country Country { get; set; }
        public ICollection<ClientOrders> ClientOrders { get; set; }
    }
}
