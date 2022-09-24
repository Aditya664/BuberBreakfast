using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuberBreakfast.Contracts.Breakfast;
using BuberBreakfast.Models;
using BuberBreakfast.Services.Breakfast;
using Microsoft.AspNetCore.Mvc;

namespace BuberBreakfast.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BuberBreakfastController : ControllerBase
    {
        private readonly IBreakfastService _service;
        public BuberBreakfastController (IBreakfastService breakfast){
            _service = breakfast;
        }
        [HttpPost]
        public IActionResult CreateBreakfast(CreateBreakfastRequest request)
        {
            Breakfasts breakfast = _service.CreateBreakfastWithRequest(request);
            _service.CreateBreakfast(breakfast);
            var breakfastResponse = _service.CreateBreakfastResponse(breakfast);
            return CreatedAtAction(nameof(GetBreakfast),new {id = breakfast.Id}, breakfastResponse);
        }

        [HttpGet("{id:guid}")]
        public IActionResult GetBreakfast(Guid id)
        {
            Breakfasts breakfast = _service.GetBreakfast(id);
            var breakfastResponse = _service.CreateBreakfastResponse(breakfast);
            return Ok(breakfastResponse);
        }

        [HttpPut("{id:guid}")]
        public IActionResult UpsertBreakfast(Guid id, UpsertBreakfastRequest request)
        {
            return Ok(request);
        }

        [HttpDelete("{id:guid}")]
        public IActionResult DeleteBreakfast(Guid id)
        {
            return Ok(id);
        }

    }
}