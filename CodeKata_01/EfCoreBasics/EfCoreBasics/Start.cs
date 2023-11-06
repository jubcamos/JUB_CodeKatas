using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreBasics
{
    //TODO: Fake Daten für Adressen und Publisher hinzufügen. Wie mache ich das es stufenweise funktioniert?
    public class Start
    {

        public static void Main(string[] args)
        {
           // var developers = createFakeData();
        }

       /* static List<DeveloperStudio> createFakeData()
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
                            Genres = new List<string>
                            {
                                "Soulslike", "Dark Fanatsy", "Action"
                            }
                         },
                        new Game
                        {
                            Name = "Eldenring",
                            Description = "Become Eldenlord",
                            Price = 60.00,
                            RealeaseDate = new DateTime(),
                            Genres = new List<string>
                            {
                                "Soulslike", "Fanatsy", "Action", "Adventure", "OpenWorld"
                            }
                        },

                        new Game
                        {
                            Name = "Bloodborn",
                            Description = "Collect souls, defeat enemys and become god",
                            Price =35.75,
                            RealeaseDate = new DateTime(),
                            Genres = new List<string>
                            {
                                "Soulslike", "Dark Fanatsy", "Action", "Adventure"
                            }
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
                            Genres = new List<string>
                            {
                                "Action", "Sandbox", "RPG", "OpenWorld"
                            }
                         },
                        new Game
                        {
                            Name = "Battlerite",
                            Description = "Become Eldenlord",
                            Price = 0.00,
                            RealeaseDate = new DateTime(),
                            Genres = new List<string>
                            {
                                "Moba", "Multiplayer", "Action"
                            }
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
                            Genres = new List<string>
                            {
                                "Moba", "Multiplayer", "Strategy"
                            }
                         },
                        new Game
                        {
                            Name = "Legends Of Runterra",
                            Description = "Kartgame in the League Of Legends Universe",
                            Price = 0.00,
                            RealeaseDate = new DateTime(),
                            Genres = new List<string>
                            {
                                "Strategy", "Multiplayer", "Kartgame"
                            }
                        }

                    }
                },

            };

            return developers;
        }*/
    }
}
