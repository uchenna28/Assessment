using Application.Student.Model;
using Application.Student.Services;
using Application.Teacher.Model;
using AutoMapper;
using Domain.Common;
using Domain.Contracts;
using Domain.Entities;
using Infrastructure.Persistance;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Implementation
{
    public class StudentService : IStudentService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unit;
        public StudentService(ApplicationDbContext context, IMapper mapper, IUnitOfWork unit)
        {
            _context = context;
            _mapper = mapper;
            _unit = unit;
        }
        public async Task<ResponseModel<StudentResponseModel>> CreateStudent(StudentRequestModel model)
        {
            Student student = new Student();
            student.Surname = model.Surname;
            student.Name = model.Name;
            student.StudentNumber = model.StudentNumber;
            student.DateOfBirth = model.DateOfBirth;

            await _context.Students.AddAsync(student);
            _context.SaveChanges();
            return ResponseModel<StudentResponseModel>.Success(_mapper.Map<StudentResponseModel>(student));
        }

       

    }
}
