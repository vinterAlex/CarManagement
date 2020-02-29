using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleDefinition
{
    public class Vehicle
    {
        


        public int VehicleID { get; set; }
        public string DriveType { get; set; }
        public string EngineDescription { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int ConstructionYear { get; set; }
        public DateTime ModifyDate { get; set; }
        public Int64 VehiclePrice { get; set; }

        public List<Vehicle> RetrieveAllVehicles()
        {
            //to retrieve all vehicles
            return new List<Vehicle>();
        }
       
    
        
    
    }


}
