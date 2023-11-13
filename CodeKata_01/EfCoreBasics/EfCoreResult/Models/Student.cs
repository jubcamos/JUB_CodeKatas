using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreResult.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(max)")]
        public string LastName { get; set; }

        [Required]
        [Column(TypeName = "varchar(15)")]
        public string Classyear { get; set; }

        public DateTime BirthDate { get; set; }

        public Adress? Adress { get; set; }

        public Classroom Classroom { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
