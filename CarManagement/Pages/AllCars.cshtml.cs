using System;
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


        public List<Vehicle> somedata { get; set; }


        

        public IList<string> populateFilterItems()
        {
            string queryString = "select distinct Make from Vehicles;";

            IList<string> tempList = new List<string>();

            using (SqlConnection connection = new SqlConnection("Server=ALEXV\\TESTINSTANCE;Database=shop;User ID=vinteralex;Password=blestem24;"))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (!reader.IsDBNull(0))
                    {
                        tempList.Add(reader[0].ToString());
                    }
                }
                reader.Close();
            }
            //string[] carName = tempList.ToArray();


            vehicleItemSearch = tempList.ToList();

            return vehicleItemSearch;
        }

        public async Task OnGetAsync()
        {

            VehiclesToShow = await _context.Vehicles.ToListAsync();

        }
    }
}
