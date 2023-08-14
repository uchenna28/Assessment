using Application.Teacher.Model;
using Application.Teacher.Services;
using Domain.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Teacher.Handler.Command
{
    public class CreateTeacherCommand : TeacherRequestModel, IRequest<ResponseModel<TeacherResponseModel>>
    {

    }

    public class CreateTeacherCommandHandler : IRequestHandler<CreateTeacherCommand, ResponseModel<TeacherResponseModel>>
    {
        private readonly ITeacherService _service;
        public CreateTeacherCommandHandler(ITeacherService service)
        {
            _service = service;
        }
        public async Task<ResponseModel<TeacherResponseModel>> Handle(CreateTeacherCommand request, CancellationToken cancellationToken)
        {
            return await _service.CreateTeachers(request);
        }
    }
}
