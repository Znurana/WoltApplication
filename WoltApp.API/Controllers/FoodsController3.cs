using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WoltApp.BLL.Services.Contracts;
using WoltApp.DAL.Data;
using WoltApp.DAL.Dto;
using WoltApp.DAL.Model;
using WoltApp.DAL.Repository.Contracts;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WoltApp.API.Controllers
{
    [Route("api/[controller]")]
    public class FoodsController3 : Controller
    {
        private readonly IFoodService _service;

        public FoodsController3(IFoodService service)
        {
            _service = service;
        }

        // GET: api/values
        [HttpGet]
        public IActionResult Get()
        {
            var items = _service.GetList();
            return Ok(items);

        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var item = _service.Get(id);
            if (item != null)
            {
                return Ok(item);
            }
            return BadRequest();
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] FoodDto foodDto)
        {

            var item = _service.Add(foodDto);
            return Ok(item);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] FoodDto dto)
        {
            var item = _service.Update(id, dto);

            return Ok(item);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            bool response = _service.Remove(id);
            return Ok(response);

        }
    }
}

