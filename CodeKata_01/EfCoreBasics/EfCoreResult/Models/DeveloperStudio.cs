using EfCoreResult.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreResults.Models
{
    public class DeveloperStudio
    {
        public int DeveloperStudioId { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string Name { get; set; }
        public ICollection<Game> DevelopedGames { get; set; }

        [Column(TypeName = "varchar(max)")]
        public string? City { get; set; }

        [Column(TypeName = "varchar(max)")]
        public string? Country { get; set; }

        public List<Partnership> Partnerships { get; set; }
    }
}
