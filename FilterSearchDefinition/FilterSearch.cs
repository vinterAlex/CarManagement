using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FilterSearchDefinition
{
    public class FilterSearch 
    {
        public string VehicleDriveTypeFilter  { get; set; }
        public string VehicleEngineDescriptionFilter { get; set; }
        public string VehicleMakeFilters { get; set; }
        public string VehicleModelFilter { get; set; }
        public int VehicleConstructionYearFilter { get; set; }
        
    }
}
