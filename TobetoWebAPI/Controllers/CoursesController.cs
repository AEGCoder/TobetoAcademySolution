using Business.Abstract;
using Business.Concreate;
using DataAccess.Concreate.EntityFramework;
using Entities.Concreate;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TobetoWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        ICourseService _courseService;
        public CoursesController(ICourseService courseService)
        {
            _courseService = courseService;
        }
        [HttpGet("getall")]
        public IActionResult Get()
        {
            
            var result = _courseService.GetAll();

            if (result.Success)
            {
                return Ok(result);
            }
            
            return BadRequest(result);
        }


        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result = _courseService.GetById(id);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }






        [HttpPost("add")]
        public IActionResult Post(Course course)
        {
            var result = _courseService.Add(course);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }   
    }
}
