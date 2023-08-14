using Domain.Contracts;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistance.Repository
{
   public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private readonly IBaseRepository<Teacher> _teacher;
        private readonly IBaseRepository<Student> _student;
         public UnitOfWork(ApplicationDbContext context)
        {

            _context = context;

        }
        public IBaseRepository<Student> _StudentRepository => throw new NotImplementedException();

        public IBaseRepository<Teacher> _TeacherRepository => throw new NotImplementedException();

        public void Dispose()
        {
           _context.Dispose();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
