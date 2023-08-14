using Application.Teacher.Handler.Command;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Host.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly IMediator _mediator;
        public TeacherController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Route("Create")]
      public async Task<IActionResult> CreateTeacher([FromBody]CreateTeacherCommand create)
        {
            var teacher = await _mediator.Send(create);
            return Ok(teacher);
        }

      
    }
}
