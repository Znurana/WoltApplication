using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WoltApp.DAL.Data;
using WoltApp.DAL.Dto;
using WoltApp.DAL.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WoltApp.API.Controllers
{
    [Route("api/[controller]")]
    public class FoodsController : Controller
    {
        private readonly WoltDbContext _dbcontext;

        public FoodsController(WoltDbContext context)
        {
            this._dbcontext = context;
        }

        // GET: api/values
        [HttpGet]
        public IActionResult Get()
        {
            List<Food> foods = _dbcontext.Foods.ToList();
            return Ok(foods);
            
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Food food = _dbcontext.Foods.Where(f => f.Id == id).FirstOrDefault();
            if(food != null)
            {
                return Ok(food);
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
            _dbcontext.Foods.Add(food);

            _dbcontext.SaveChanges();
            return Ok();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Food newfood)
        {
            Food food = _dbcontext.Foods.Where(f => f.Id == id).FirstOrDefault();
            if(food!= null)
            {
                food.Name = newfood.Name;
                food.Description = newfood.Description;
                _dbcontext.Foods.Update(food);
                _dbcontext.SaveChanges();
                return Ok(food);
            }
            return BadRequest();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
             Food food= _dbcontext.Foods.Where(f => f.Id == id).FirstOrDefault();
            if(food != null)
            {
                _dbcontext.Foods.Remove(food);
                _dbcontext.SaveChanges();
                return Ok(food);
            }
            return BadRequest();
            
        }
    }
}

