using System;
using System.Collections.Generic;
using VehicleDefinition;

namespace CarManagement.Models
{
    public partial class Vehicles
    {
        Vehicle v = new Vehicle();

        public int VehicleId { get;set;}
        public string DriveType { get; set; }
        public string EngineDescription { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public short ConstructionYear { get; set; }
        public DateTime ModifyDate { get; set; }
        public long? VehiclePrice { get; set; }
    }
}
