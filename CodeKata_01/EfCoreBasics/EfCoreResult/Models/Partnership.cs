using EfCoreResults.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace EfCoreResult.Models
{
    public class Partnership
    {
        public int Id;
        public int? DeveloperId { get; set; }
        public DeveloperStudio DeveloperStudio { get; set; }

        public int? PublisherId { get; set; }
        public Publisher Publisher { get; set; }
    }
}