using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreResult.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public float Duration { get; set; }

        public ICollection<Student> Students { get; set; }

    }
}
