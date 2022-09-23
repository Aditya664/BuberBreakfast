using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuberBreakfast.Contracts.Breakfast;
using Microsoft.AspNetCore.Mvc;

namespace BuberBreakfast.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BuberBreakfastController : ControllerBase
    {
        [HttpPost("/api/breakfast")]
        public IActionResult CreateBreakfast(CreateBreakfastRequest request){
            return Ok(request);
        }

        [HttpGet("/api/breakfast/{id:guid}")]    
        public IActionResult GetBreakfast(Guid id){
            return Ok(id);  
        }

        [HttpPut("/api/breakfast/{id:guid}")] 
        public IActionResult UpsertBreakfast(Guid id, UpsertBreakfastRequest request){
            return Ok(request);
        }

        [HttpDelete("/api/breakfast/{id:guid}")]    
        public IActionResult DeleteBreakfast(Guid id){
            return Ok(id);  
        }

    }
}