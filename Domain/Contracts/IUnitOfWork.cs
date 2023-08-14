using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts
{
    public interface IUnitOfWork : IDisposable
    {
        public IBaseRepository<Student> _StudentRepository { get; }
        public IBaseRepository<Teacher> _TeacherRepository { get; }

        void SaveChanges();
    }
}
