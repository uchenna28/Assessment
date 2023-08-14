using Application.Student.Model;
using Application.Teacher.Model;
using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Student.Services
{
    public interface IStudentService
    {
        Task<ResponseModel<StudentResponseModel>> CreateStudent(StudentRequestModel model);
       
    }
}
