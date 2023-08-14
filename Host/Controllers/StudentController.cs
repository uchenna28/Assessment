using Application.Student.Handler.Command;
using Application.Teacher.Handler.Command;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Host.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IMediator _mediator;
        public StudentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> CreateStudent([FromBody] CreateStudentCommand create)
        {
            var student = await _mediator.Send(create);
            return Ok(student);
        }
    }
}
