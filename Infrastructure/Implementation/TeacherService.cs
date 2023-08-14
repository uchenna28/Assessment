using Application.Teacher.Model;
using Application.Teacher.Services;
using AutoMapper;
using Domain.Common;
using Domain.Common.Enums;
using Domain.Contracts;
using Domain.Entities;
using Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Implementation
{
    public class TeacherService : ITeacherService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unit;
        public TeacherService(ApplicationDbContext context, IMapper mapper, IUnitOfWork unit)
        {
            _context = context;
            _mapper = mapper;
            _unit = unit;
        }
        public async Task<ResponseModel<TeacherResponseModel>> CreateTeachers(TeacherRequestModel model)
        {
          
              Teacher teacher = new Teacher();
              teacher.Surname = model.Surname;
              teacher.Name = model.Name;
              teacher.Salary = model.Salary;
              teacher.TeacherNumber = model.TeacherNumber;
              teacher.DateOfBirth = model.DateOfBirth;
              teacher.Title = model.Title;

          await  _context.Teachers.AddAsync(teacher);
            _context.SaveChanges();
            return ResponseModel<TeacherResponseModel>.Success(_mapper.Map<TeacherResponseModel>(teacher));
        }

    }
}
