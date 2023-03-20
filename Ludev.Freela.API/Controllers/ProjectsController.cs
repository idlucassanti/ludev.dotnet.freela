using Ludev.Freela.API.Constants;
using Ludev.Freela.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Ludev.Freela.API.Controllers
{
    [ApiController]
    [Route("api/projects")]
    public class ProjectsController : ControllerBase
    {
        private readonly AppSettings _settings;

        public ProjectsController(IOptions<AppSettings> settings, ExempleInjection injection)
        {
            _settings = settings.Value;

            injection.Name = injection.Name;
        }

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

        // api/projects/1/comments
        [HttpPost("{id}/comments")]
        public IActionResult PostComment(int id, [FromBody] CreateCommentModel createComment)
        {
            return NoContent();
        }

        // api/projects/1/start
        [HttpPut("{id}/start")]
        public IActionResult Start(int id)
        {
            return NoContent();
        }

        // api/projects/1/finish
        [HttpPut("{id}/finish")]
        public IActionResult Finish(int id)
        {
            return NoContent();
        }
    }
}