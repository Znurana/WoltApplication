using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WoltApp.DAL.Data;
using WoltApp.DAL.Dto;
using WoltApp.DAL.Model;
using WoltApp.DAL.Repository.Contracts;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WoltApp.API.Controllers
{
    [Route("api/[controller]")]
    public class FoodsController2 : Controller
    {
        private readonly IFoodRepository _repository;

        public FoodsController2(IFoodRepository repository)
        {
            _repository = repository;
        }

        // GET: api/values
        [HttpGet]
        public IActionResult Get()
        {
            var items= _repository.GetList();
            return Ok(items);
            
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var item = _repository.Get(id);
            if(item != null)
            {
                return Ok(item);
            }
            return BadRequest();
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]FoodDto foodDto)
        {
            Food food = new Food()
            {
                Name = foodDto.Name,
                CategoryId = foodDto.CategoryId,
                Description=foodDto.Description,
                Price=foodDto.Price,
                Ingredients=foodDto.Ingredients,
                Rating=foodDto.Rating,
                IsActive=true

            };
            _repository.Add(food);
            return Ok();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Food newfood)
        {
            Food food = _repository.Update(id, newfood);
           
            return Ok(food);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            bool response = _repository.Remove(id);
            return Ok(response);
            
        }
    }
}

