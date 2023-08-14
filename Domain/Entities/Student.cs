using Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
     public class Student : BaseEntity
    {
        [Required]
        public string Name { get; set; }= "";
        [Required]
        public string Surname { get; set; } = "";
        public DateTime DateOfBirth { get; set; }
        public int StudentNumber { get; set; }
    }
}
