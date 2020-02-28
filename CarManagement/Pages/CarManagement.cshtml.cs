using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VehicleDefinition;


namespace CarManagement
{
    public class CarManagementModel : PageModel
    {
        Vehicle vehicle = new Vehicle();
        
        


        public void OnGet()
        {
            
        }
    }
}