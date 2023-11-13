
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKatas.Entity
{
    public class Game
    {
        public int GameId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DeveloperStudio developer { get; set; }
        public DateTime RealeaseDate { get; set; }
        public List<string> Genres { get; set; }
        public double Price { get; set; }
    }
}
