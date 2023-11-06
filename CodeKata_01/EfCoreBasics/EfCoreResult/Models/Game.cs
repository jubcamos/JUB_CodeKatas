
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreResults.Models
{
    public class Game
    {
        public int GameId { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string Name { get; set; }

        [Column(TypeName = "varchar(max)")]
        public string? Description { get; set; }
        public DeveloperStudio developer { get; set; }
        public DateTime RealeaseDate { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string Genre { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        public double Price { get; set; }
    }
}
