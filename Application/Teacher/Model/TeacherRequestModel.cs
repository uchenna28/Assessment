using Domain.Common.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Teacher.Model
{
    public class TeacherRequestModel
    {
        public Title Title { get; set; } 
        [Required]
        public string Name { get; set; } = "";
        [Required]
        public string Surname { get; set; } = "";
        public DateTime DateOfBirth { get; set; }
        public long TeacherNumber { get; set; }
        public decimal Salary { get; set; }
    }
}
