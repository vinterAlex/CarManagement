using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CarManagement.Models;

namespace CarManagement
{
    public class AllCarsModel : PageModel
    {
        //get the connection from "shop" db
        private readonly CarManagement.Models.shopContext _context;

        public AllCarsModel(CarManagement.Models.shopContext context)
        {
            _context = context;
        }

        public IList<Vehicles> Vehicles { get;set; } //to retrieve all cars

        public async Task OnGetAsync()
        {
            Vehicles = await _context.Vehicles.ToListAsync();
        }
    }
}
