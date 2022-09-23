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
        [HttpPost("/api/breakfasts")]
        public IActionResult CreateBreakfast(CreateBreakfastRequest request){
            return Ok(request);
        }

        [HttpGet("/api/breakfasts/{id:guid}")]    
        public IActionResult GetBreakfast(Guid id){
            return Ok(id);  
        }

        [HttpPut("/api/breakfasts/{id:guid}")] 
        public IActionResult UpsertBreakfast(Guid id, UpsertBreakfastRequest request){
            return Ok(request);
        }

        [HttpDelete("/api/breakfasts/{id:guid}")]    
        public IActionResult DeleteBreakfast(Guid id){
            return Ok(id);  
        }

    }
}