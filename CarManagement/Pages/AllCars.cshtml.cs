using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CarManagement.Models;
using VehicleDefinition;

namespace CarManagement
{
    public class AllCarsModel : PageModel
    {
        Vehicle vehicle_details = new Vehicle();
        //get the connection from "shop" db
        private readonly shopContext _context;

        public AllCarsModel(shopContext context)
        {
            _context = context;
        }

        public IList<Vehicle> VehiclesToShow { get;set; } //to retrieve all cars
        public IList<Vehicle> DistinctData { get; set; }


        public async Task OnGetAsync()
        {
            VehiclesToShow = await _context.Vehicles.Distinct().ToListAsync();
            //VehiclesToShow = await _context.Vehicles.ToListAsync();

        }
    }
}
