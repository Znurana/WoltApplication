using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WoltApp.BLL.Services.Contracts;
using WoltApp.DAL.Data;
using WoltApp.DAL.Dto;

namespace WoltApp.API.Controllers
{
    [Route("api/[controller]")]
    public class CategoryController : Controller
    {

        private readonly ICategoryService _service;

        public CategoryController(ICategoryService service)
        {
            _service = service;
        }

        // GET: api/values
        [HttpGet]
        public ActionResult Get()
        {
            var item = _service.GetList();
            return Ok(item);

        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var item = _service.Get(id);
            return Ok(item);
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] CategoryDto dto)
        {
            var item = _service.Add(dto);
            return Ok(item);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            //var item = _service.Update(dto);
            //return Ok(item);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            bool item = _service.Remove(id);
            return Ok(item);
        }
    }
}

