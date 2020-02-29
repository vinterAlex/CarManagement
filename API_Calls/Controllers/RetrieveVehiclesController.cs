using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarManagement.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using VehicleDefinition;


namespace API_Calls.Controllers
{
    


    [Route("api/[controller]")]
    [ApiController]
    public class RetrieveVehiclesController : ControllerBase
    {
        private readonly CarManagement.Models.shopContext _Carcontext;
        public IEnumerable<Vehicles> Vehicles { get; set; } //to retrieve all cars

        // GET: api/RetrieveVehicles
        public RetrieveVehiclesController(CarManagement.Models.shopContext context)
        {
            _Carcontext = context;
        }

        [HttpGet("{id}", Name = "Get")]
        public async Task<ActionResult<List<Vehicle>>> Get (List<Vehicle> masinute)
        {
            return  new List<Vehicle>(masinute);



                //return _Carcontext.Vehicles.ToList();
        }

        // GET: api/RetrieveVehicles
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET: api/RetrieveVehicles/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {



            return "value";
        }

        // POST: api/RetrieveVehicles
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/RetrieveVehicles/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
