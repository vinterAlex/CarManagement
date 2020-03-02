using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CarManagement.Models;
using VehicleDefinition;
using System.Collections;

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
        public IList<Vehicle> filterItem { get; set; } //to retrieve Make for filter

        public IList<Vehicle> filterOptions { get; set; }

        //public List<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> filterOptions { get; set; }

            


        public async Task OnGetAsync()
        {

            VehiclesToShow = await _context.Vehicles.ToListAsync();

            filterOptions = await _context.Vehicles.Distinct().ToListAsync();


            //filterOptions = _context.Vehicles.Select(a =>
            //new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem
            //{
            //    Value = a.Make.ToString()
            //}).ToList();
        }




    }
}
