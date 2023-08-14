using Application.Student.Model;
using Application.Teacher.Model;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.AutoMapper
{
    public class Automapping : Profile
    {
        public Automapping()
        {
            CreateMap<Teacher, TeacherRequestModel>().ReverseMap();
            CreateMap<Teacher, TeacherResponseModel>().ReverseMap();
            CreateMap<Student,StudentRequestModel>().ReverseMap();
            CreateMap<Student,StudentResponseModel>().ReverseMap();
        }
    }
}
