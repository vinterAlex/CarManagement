using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PersonDefinition;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VehicleDefinition;
using CarManagement.Models;

namespace CarManagement
{
    public class CarManagementModel : PageModel
    {
        Vehicle vehicle = new Vehicle();    
        private shopContext vehicleDB = new shopContext();
        
        
        public void OnGet()
        {
            ShowAllCars();

        }


        public List<Vehicles> ShowAllCars()
        {
            return vehicleDB.Vehicles.ToList();
            
        }

    }

    


}