using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Repository;

namespace WebApplication.Controllers
{
    [Route("api/[controller]")]
    public class HerosController : Controller
    {
        private IRepository _repo;

        public HerosController(IRepository repository)
        {
            _repo = repository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var results = _repo.Get();
                if (results != null)
                    return Ok(results);
                else
                    return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                if (id == 0)
                    return BadRequest();

                var result = _repo.GetByID(id);

                if (result != null)
                    return Ok(result);
                else
                    return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

    }
}
