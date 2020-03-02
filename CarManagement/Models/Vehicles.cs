using System;
using System.Collections.Generic;
using VehicleDefinition;

namespace CarManagement.Models
{
    public partial class Vehicles_OUT 
    {
        
        
        
        //public int VehicleIds { get;set;}
        public int VehicleId { get; set; }
        public string DriveType { get; set; }
        public string EngineDescription { get; set; }
        public string Make { get;set; }
        public string Model { get; set; }
        public int ConstructionYear { get; set; }
        public DateTime? ModifyDate { get; set; }
        public long? VehiclePrice { get; set; }

        
    }
}
