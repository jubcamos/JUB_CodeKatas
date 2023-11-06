using EfCoreResults.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreResult.Models
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Budged { get; set; }
        public List<Partnership> Partnership {  get; set; }
    }
}
