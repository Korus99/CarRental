using System;
using System.Collections.Generic;
using System.Linq;
using CarRentalApp.MobileAppService.Models;
using CarRentalApp.MobileAppService.Repository.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarRentalApp.MobileAppService.Controllers
{
    [Route("api/vehicle")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleBusiness _vehicleBusiness;

        public VehicleController(IVehicleBusiness vehicleBusiness)
        {
            _vehicleBusiness = vehicleBusiness;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<Vehicle>> List()
        {
            return _vehicleBusiness.GetAll().ToList();
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Vehicle> GetVehicle(int id)
        {
            var vehicle = _vehicleBusiness.Get(id);

            if (vehicle == null)
                return NotFound();

            return vehicle;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Vehicle> Create([FromBody]Vehicle vehicle)
        {
            _vehicleBusiness.Add(vehicle);
            return CreatedAtAction(nameof(GetVehicle), new { vehicle.Id }, vehicle);
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Edit([FromBody] Vehicle vehicle)
        {
            try
            {
                _vehicleBusiness.Update(vehicle);
            }
            catch (Exception)
            {
                return BadRequest("Error while creating");
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult Delete(int id)
        {
            var vehicle = _vehicleBusiness.Remove(id);

            if (vehicle == null)
                return NotFound();

            return Ok();
        }
    }
}
