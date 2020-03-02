﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CarManagement.Models;
using VehicleDefinition;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CarManagement
{
    public class AllCarsModel : PageModel
    {
        Vehicle vehicle_details = new Vehicle();
        //get the connection from "shop" db
        private readonly shopContext _context;

        public IList<Vehicle> VehiclesToShow { get; set; } //to retrieve all cars
        public IList<string> vehicleItemSearch { get; set; }

        public AllCarsModel(shopContext context)
        {
            _context = context;
        }


        public List<Vehicle> filterOptions { get; set; }

        public List<Vehicle> filterOptionsValidation { get; set; }







        public async Task OnGetAsync()
        {

            VehiclesToShow = await _context.Vehicles.ToListAsync();

            filterOptions= await _context.Vehicles.ToListAsync();

            //filterOptionsValidation = await _context.Vehicles.Where(x=>x.Checked_Make() ==true).ToListAsync();

        }
    }
}
