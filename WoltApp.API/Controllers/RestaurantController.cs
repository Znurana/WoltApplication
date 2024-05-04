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
    public class RestaurantController : Controller
    {
        private readonly WoltDbContext _dbContext;
        public RestaurantController(WoltDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        // GET: api/values
        [HttpGet]
        public IActionResult Get()
        {
            List<RestaurantDto> dtos = new List<RestaurantDto>();
            var items = _dbContext.Restaurants.ToList();
            foreach (var item in items)
            {
                RestaurantDto dto = new RestaurantDto()
                {
                    Name = item.Name,
                    Description = item.Description,
                    City = item.City,
                    Rating = item.Rating,
                    Type = item.Type,
                    Id = item.Id

                };
                if (dto.Rating >= 2)
                {
                    dtos.Add(dto);
                }

            }
            return Ok(dtos);

        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var item = _dbContext.Restaurants.Where(x => x.Id == id).FirstOrDefault();
            if (item != null)
            {
                RestaurantDto dto = new RestaurantDto()
                {
                    Id = item.Id,
                    Name = item.Name,
                    Rating = item.Rating,
                    Description = item.Description,
                    City = item.City,
                    Type = item.Type
                };
                return Ok(dto);
            }
            else
            {
                return NotFound();
            }


        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] RestaurantDto dto)
        {
            Restaurant entity = new Restaurant()
            {
                Name = dto.Name,
                City = dto.City,
                Description = dto.Description,
                Rating = dto.Rating,
                Type = dto.Type,

            };
            _dbContext.Restaurants.Add(entity);
            _dbContext.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] RestaurantDto dto)
        {
            var item = _dbContext.Restaurants.Where(x => x.Id == id).FirstOrDefault();

            item.Name = dto.Name;
            item.Description = dto.Description;
            item.City = dto.City;
            item.Rating = dto.Rating;
            item.Type = dto.Type;

            _dbContext.Restaurants.Update(item);
            _dbContext.SaveChanges();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var item = _dbContext.Restaurants.Where(x => x.Id == id).FirstOrDefault();
            _dbContext.Restaurants.Remove(item);
            _dbContext.SaveChanges();
            return Ok();

        }
    }
}

