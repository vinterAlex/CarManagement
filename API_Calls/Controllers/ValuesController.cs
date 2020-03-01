using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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
    public class ValuesController : ControllerBase
    {


        private readonly CarManagement.Models.shopContext _Carcontext;
        public IEnumerable<Vehicles> Vehicles { get; set; } //to retrieve all cars

        // GET: api/RetrieveVehicles
        public ValuesController(CarManagement.Models.shopContext context)
        {
            _Carcontext = context;
        }




        // GET api/values
        [HttpGet]
        public async Task<ActionResult<List<Vehicle>>> Get(List<Vehicle> masinute)
        {
            return new List<Vehicle>(masinute);
            //   return new string[] { "value1", "value2" ,"valoarea 3"};
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
