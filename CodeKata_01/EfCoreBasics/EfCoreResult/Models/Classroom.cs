using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreResult.Models
{
    public class Classroom
    {
        [Key]
        [Column("Id")]
        public int ClassroomNumber { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public int Seates { get; set; }
        public List<Student> Students { get; set; }

        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
    }
}
