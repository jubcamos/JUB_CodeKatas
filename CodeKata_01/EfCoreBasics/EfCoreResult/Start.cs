using EfCoreResults.Data;
using EfCoreResults.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreResults
{
    //TODO: Fake Daten für Adressen und Publisher hinzufügen. Wie mache ich das es stufenweise funktioniert?
    public class Start
    {

        public static void Main(string[] args)
        {
            GameLibraryContext context = new GameLibraryContext();

            //List<DeveloperStudio> developers = createFakeData();

            //context.DeveloperStudios.AddRange(developers);

            //context.SaveChanges();

            var developer = context.DeveloperStudios.Where(d => d.Name == "FromSoftware").FirstOrDefault();

            var games = context.Games.Where(d => d.Genre == "OpenWorld");

            foreach ( var game in games )
            {
                game.Price *= 0.95;
            }

            var developers = context.DeveloperStudios.Include(d => d.DevelopedGames.Where(g => g.Genre == "OpenWorld")).Select(n => n.Name).ToList();

            foreach ( var Name in developers ) { 
                Console.WriteLine(Name);
            }

            context.SaveChanges();
        }

        static List<DeveloperStudio> createFakeData()
        {

            var developers = new List<DeveloperStudio>
            {
                new DeveloperStudio
                {
                    Name = "FromSoftware",
                    DevelopedGames = new List<Game>
                    {
                        new Game
                         {
                            Name = "Dark Souls",
                            Description = "Collect souls, defeat enemys and become god",
                            Price = 25.99,
                            RealeaseDate = new DateTime(),
                            Genre = "Soulslike"

                         },
                        new Game
                        {
                            Name = "Eldenring",
                            Description = "Become Eldenlord",
                            Price = 60.00,
                            RealeaseDate = new DateTime(),
                            Genre = "OpenWorld"
                        },

                        new Game
                        {
                            Name = "Bloodborn",
                            Description = "Collect souls, defeat enemys and become god",
                            Price =35.75,
                            RealeaseDate = new DateTime(),
                            Genre = "Soulslike"
                        }
                    }
                },

                new DeveloperStudio
                {
                    Name = "Stunlock Studios",
                    DevelopedGames = new List<Game>
                    {
                        new Game
                         {
                            Name = "VRising",
                            Description = "Become the strongest Vampire",
                            Price = 20.00,
                            RealeaseDate = new DateTime(),
                            Genre = "OpenWorld"
                         },
                        new Game
                        {
                            Name = "Battlerite",
                            Description = "Kompetetive 3 vs 3 Arena Multiplayer",
                            Price = 0.00,
                            RealeaseDate = new DateTime(),
                            Genre = "Moba"
                        }

                    }
                },


                new DeveloperStudio
                {
                    Name = "Riot Games",
                    DevelopedGames = new List<Game>
                    {
                        new Game
                         {
                            Name = "League Of Legends",
                            Description = "Competetive Online Moba",
                            Price = 20.00,
                            RealeaseDate = new DateTime(),
                            Genre = "Moba"
                         },
                        new Game
                        {
                            Name = "Legends Of Runterra",
                            Description = "Kartgame in the League Of Legends Universe",
                            Price = 0.00,
                            RealeaseDate = new DateTime(),
                            Genre = "CardGame"
                        }

                    }
                },

            };

            return developers;
        }
    }
}
