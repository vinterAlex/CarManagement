using System;
using System.Collections.Generic;

namespace CarManagement.Models
{
    public partial class Country
    {
        public Country()
        {
            Persons = new HashSet<Persons>();
        }

        public int CountryId { get; set; }
        public string Name { get; set; }
        public string Iso2 { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? ModifyDate { get; set; }

        public ICollection<Persons> Persons { get; set; }
    }
}
