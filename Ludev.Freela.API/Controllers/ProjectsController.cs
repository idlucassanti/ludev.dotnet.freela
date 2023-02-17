using Ludev.Freela.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ludev.Freela.API.Controllers
{
    [ApiController]
    [Route("api/projects")]
    public class ProjectsController : ControllerBase
    {
        // api/projects?query=netcore
        [HttpGet]
        public IActionResult Get(string query)
        {
            return Ok();
        }

        // api/projects/1
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            //return NotFound();

            return Ok();
        }

        // api/projects
        [HttpPost]
        public IActionResult Post([FromBody] CreateProjectModel createProject)
        {
            // return BadRequest();

            return CreatedAtAction(nameof(GetById), new { id = createProject.Id }, createProject);
        }

        // api/projects/1
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateProjectModel updateProject)
        {
            // return BadRequest();
            return NoContent();
        }

        // api/projects/1
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }
    }
}