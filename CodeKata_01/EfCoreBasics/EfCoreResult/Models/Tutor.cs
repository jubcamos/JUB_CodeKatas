using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreResult.Models
{
    public class Tutor : Teacher
    {
        public string LearnGroup {  get; set; }
    }
}
