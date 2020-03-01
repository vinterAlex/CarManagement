using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using CarManagement.Models;
using FilterSearchDefinition;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using VehicleDefinition;

namespace CarManagement
{
    public class FilterViewModel : PageModel
    {
        Vehicle vehicle_details = new Vehicle();
        FilterSearch search = new FilterSearch();
        //get the connection from "shop" db
        private readonly shopContext _context;
        public IList<FilterSearch> filterSearch { get; set; } //to retrieve all cars


        public FilterViewModel(shopContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            


        }




    }
}