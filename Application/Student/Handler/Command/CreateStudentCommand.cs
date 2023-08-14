using Application.Student.Model;
using Application.Student.Services;
using Application.Teacher.Services;
using Domain.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Student.Handler.Command
{
    public class CreateStudentCommand : StudentRequestModel, IRequest<ResponseModel<StudentResponseModel>>
    {

    }

    public class CreateStudentCommandHandler : IRequestHandler<CreateStudentCommand, ResponseModel<StudentResponseModel>>
    {
        private readonly IStudentService _service;
        public CreateStudentCommandHandler(IStudentService service)
        {
            _service = service; 
        }
        public async Task<ResponseModel<StudentResponseModel>> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
        {
            return await _service.CreateStudent(request);
        }
    }
}
