using Microsoft.AspNetCore.Mvc;
using Rest_api.Data;
using Rest_api.Models;

//Vehicle Controller

namespace Rest_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {   
        private readonly IVehiclesrepository _repository;
        public VehiclesController(IVehiclesrepository repository)
        {
            _repository = repository;
        }
        

        //Vehicles
        [HttpGet(Name = "Vehicles")]
        public ActionResult<IEnumerable<Vehicles>> Get ()
        {
            var vehicles = _repository.Getallvehicles();
            return Ok(vehicles);
        }
        // Http Get Car, Boat, Bus By colour
        [HttpGet("car")]
        public IActionResult Get_Car_Bycolour([FromBody] Cars cars)
        {
            var result =  _repository.Get_Car_Bycolour(cars.Colours);
            
            return Ok(result);
        }
        [HttpGet("boat")]
        public IActionResult Get_Boats_Bycolour([FromBody] Boats boats)
        {
            var result = _repository.Get_Boats_Bycolour(boats.Colours);

            return Ok(result);
        }
        [HttpGet("bus")]
        public IActionResult Get_Buses_Bycolour([FromBody] Buses buses)
        { 
            var result = _repository.Get_Buses_Bycolour(buses.Colours);

            return Ok(result);
        }

        // Http Post Car By id to turn on/off headlights
        [HttpPost("car/headlight")]
        public IActionResult Post_Car_Byid([FromBody] Cars cars)
        {
            var result = _repository.Post_Car_Byid(cars.Id, cars.Headlights);

            return Ok(result);
        }

        // Http Delete Car By id
        [HttpDelete("car/delete")]

        public IActionResult Delete_Car_Byid([FromBody] Cars cars)
        {
            var result = _repository.Delete_Car_Byid(cars.Id);

            return Ok(result);
        }

    }
}
