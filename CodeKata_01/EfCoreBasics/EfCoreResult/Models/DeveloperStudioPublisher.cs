using EfCoreResults.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreResult.Models
{
    public class DeveloperStudioPublisher
    {
        public DeveloperStudio Developer { get; set; }
        public Publisher Publisher { get; set; }

        public int PublisherId { get; set; }
        public int DeveloperId {  get; set; }
    }
}
