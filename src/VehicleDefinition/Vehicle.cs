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
        public short ConstructionYear { get; set; }
        public DateTime? ModifyDate { get; set; }
        public long VehiclePrice { get; set; }

        //public bool Checked_Make()
        //{
        //    return true;
        //}
        


        public List<Vehicle> RetrieveAllVehicles()
        {
            //to retrieve all vehicles
            return new List<Vehicle>();
        }
       
    
        
    
    }


}
