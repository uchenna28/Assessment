using Application.Teacher.Model;
using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Teacher.Services
{
    public interface ITeacherService
    {
        Task<ResponseModel<TeacherResponseModel>> CreateTeachers(TeacherRequestModel model);
    }
}
