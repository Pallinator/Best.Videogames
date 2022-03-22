using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using Best.Videogames.Data;

namespace VideoGame.Model
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BestVideogamesContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<BestVideogamesContext>>()))
            {
                // Look for any movies.
                if (context.VideoGame.Any())
                {
                    return;   // DB has been seeded
                }

                context.VideoGame.AddRange(
                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Call of Duty: Black Ops III",
                        ReleaseDate = DateTime.Parse("2015-11-5"),
                        Genre = "FPS",
                        Price = 60.00M,
                        Number = 1
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Overwatch ",
                        ReleaseDate = DateTime.Parse("2016-5-24"),
                        Genre = "FPS",
                        Price = 40.00M,
                        Number = 2
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Destiny 2",
                        ReleaseDate = DateTime.Parse("2017-9-6"),
                        Genre = "FPS",
                        Price = 0.00M,
                        Number = 4
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "League of Legends",
                        ReleaseDate = DateTime.Parse("2009-10-27"),
                        Genre = "MOBA",
                        Price = 0.00M,
                        Number = 3
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Call of Duty: Black Ops II",
                        ReleaseDate = DateTime.Parse("2012-11-12"),
                        Genre = "FPS",
                        Price = 60.00M,
                        Number = 5
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Call of Duty:Black Ops",
                        ReleaseDate = DateTime.Parse("2010-11-9"),
                        Genre = "FPS",
                        Price = 60.00M,
                        Number = 6
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Valorant",
                        ReleaseDate = DateTime.Parse("2020-6-2"),
                        Genre = "FPS",
                        Price = 0.00M,
                        Number = 7
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Rainbow Six Siege",
                        ReleaseDate = DateTime.Parse("2015-12-1"),
                        Genre = "FPS",
                        Price = 60.00M,
                        Number = 8
                    }
                    ,new Best.Videogames.Models.VideoGame
                    {
                        Title = "Call of Duty: Black Ops IV",
                        ReleaseDate = DateTime.Parse("2018-10-12"),
                        Genre = "FPS",
                        Price = 60.00M,
                        Number = 9
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Phasmophobia",
                        ReleaseDate = DateTime.Parse("2020-9-18"),
                        Genre = "FPS",
                        Price = 30.00M,
                        Number = 10
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Destiny",
                        ReleaseDate = DateTime.Parse("2014-9-9"),
                        Genre = "FPS",
                        Price = 60.00M,
                        Number = 11
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Splinter Cell",
                        ReleaseDate = DateTime.Parse("2002-1-17"),
                        Genre = "TPS",
                        Price = 20.00M,
                        Number = 12
                    },
                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Knights of The Old Republic",
                        ReleaseDate = DateTime.Parse("2003-7-15"),
                        Genre = "FPS",
                        Price = 30.00M,
                        Number = 13
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Mario Odessey",
                        ReleaseDate = DateTime.Parse("2017-10-27"),
                        Genre = "Open World",
                        Price = 40.00M,
                        Number = 14
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Battlefront",
                        ReleaseDate = DateTime.Parse("2004-9-20"),
                        Genre = "TPS",
                        Price = 30.00M,
                        Number = 15
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Battlefront II",
                        ReleaseDate = DateTime.Parse("2005-10-31"),
                        Genre = "TPS",
                        Price = 30.00M,
                        Number = 16
                    },
                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Star Wars: Battlefront",
                        ReleaseDate = DateTime.Parse("2015-11-16"),
                        Genre = "TPS",
                        Price = 60.00M,
                        Number = 17
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Star Wars: Battlefront II",
                        ReleaseDate = DateTime.Parse("2017-11-17"),
                        Genre = "TPS",
                        Price = 60.00M,
                        Number = 18
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Legend of Zelda: Ocarina of Time",
                        ReleaseDate = DateTime.Parse("1998-11-21"),
                        Genre = "Open World",
                        Price = 20.00M,
                        Number = 19
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Legend of Zelda: Breath of The Wild",
                        ReleaseDate = DateTime.Parse("2017-3-3"),
                        Genre = "Open World",
                        Price = 40.00M,
                        Number = 20
                    },
                    
                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Grand Theft Auto V",
                        ReleaseDate = DateTime.Parse("2013-9-17"),
                        Genre = "FPS",
                        Price = 60.00M,
                        Number = 21
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Minecraft",
                        ReleaseDate = DateTime.Parse("2011-9-18"),
                        Genre = "Survival",
                        Price = 40.00M,
                        Number = 22
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Red Dead Redemption",
                        ReleaseDate = DateTime.Parse("2010-5-18"),
                        Genre = "TPS",
                        Price = 60.00M,
                        Number = 23
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Red Dead Redemption II",
                        ReleaseDate = DateTime.Parse("2018-10-26"),
                        Genre = "TPS",
                        Price = 60.00M,
                        Number = 24
                    },
                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "The Last of Us",
                        ReleaseDate = DateTime.Parse("2013-6-14"),
                        Genre = "TPS",
                        Price = 60.00M,
                        Number = 25
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Halo: Combat Evolved",
                        ReleaseDate = DateTime.Parse("2001-11-15"),
                        Genre = "FPS",
                        Price = 40.00M,
                        Number = 26
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Halo 2",
                        ReleaseDate = DateTime.Parse("2004-11-9"),
                        Genre = "FPS",
                        Price = 40.00M,
                        Number = 27
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Halo 3",
                        ReleaseDate = DateTime.Parse("2007-9-25"),
                        Genre = "FPS",
                        Price = 60.00M,
                        Number = 28
                    },
                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Halo 4",
                        ReleaseDate = DateTime.Parse("2012-11-6"),
                        Genre = "FPS",
                        Price = 60.00M,
                        Number = 29
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Halo 5",
                        ReleaseDate = DateTime.Parse("2015-10-27"),
                        Genre = "FPS",
                        Price = 60.00M,
                        Number = 30
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Halo: Infinate",
                        ReleaseDate = DateTime.Parse("2021-11-8"),
                        Genre = "FPS",
                        Price = 60.00M,
                        Number = 31
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Halo Reach",
                        ReleaseDate = DateTime.Parse("2010-9-14"),
                        Genre = "FPS",
                        Price = 60.00M,
                        Number = 32
                    },
                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Skyrim",
                        ReleaseDate = DateTime.Parse("2011-11-11"),
                        Genre = "FPS",
                        Price = 60.00M,
                        Number = 33
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "God of War",
                        ReleaseDate = DateTime.Parse("2018-4-20"),
                        Genre = "TPS",
                        Price = 60.00M,
                        Number = 34
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Portal 2",
                        ReleaseDate = DateTime.Parse("2011-4-18"),
                        Genre = "Puzzle",
                        Price = 20.00M,
                        Number = 35
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Portal",
                        ReleaseDate = DateTime.Parse("2007-10-10"),
                        Genre = "Puzzle",
                        Price = 20.00M,
                        Number = 36
                    },
                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "The Witcher III",
                        ReleaseDate = DateTime.Parse("2015-5-18"),
                        Genre = "FPS",
                        Price = 60.00M,
                        Number = 37
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Hades",
                        ReleaseDate = DateTime.Parse("2018-11-6"),
                        Genre = "Dungeon Crawler",
                        Price = 30.00M,
                        Number = 38
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Batman: Arkham City",
                        ReleaseDate = DateTime.Parse("2011-10-18"),
                        Genre = "TPS",
                        Price = 60.00M,
                        Number = 39
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Uncharted",
                        ReleaseDate = DateTime.Parse("2007-11-19"),
                        Genre = "TPS",
                        Price = 60.00M,
                        Number = 40
                    },
                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Uncharted II",
                        ReleaseDate = DateTime.Parse("2009-10-13"),
                        Genre = "TPS",
                        Price = 60.00M,
                        Number = 41
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Call of Duty 4: Modern Warfare",
                        ReleaseDate = DateTime.Parse("2007-11-5"),
                        Genre = "FPS",
                        Price = 60.00M,
                        Number = 42
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Animal Crossing",
                        ReleaseDate = DateTime.Parse("2020-4-14"),
                        Genre = "FPS",
                        Price = 20.00M,
                        Number = 43
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "CyberPunk 2077",
                        ReleaseDate = DateTime.Parse("2020-12-10"),
                        Genre = "FPS",
                        Price = 60.00M,
                        Number = 44
                    },new Best.Videogames.Models.VideoGame
                    {
                        Title = "Metroid Prime",
                        ReleaseDate = DateTime.Parse("2002-11-18"),
                        Genre = "Side Scroller",
                        Price = 30.00M,
                        Number = 45
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Super Mario 64",
                        ReleaseDate = DateTime.Parse("1996-6-23"),
                        Genre = "Open World",
                        Price = 40.00M,
                        Number = 46
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "DOOM",
                        ReleaseDate = DateTime.Parse("1993-12-10"),
                        Genre = "FPS",
                        Price = 20.00M,
                        Number = 47
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Doom (2016)",
                        ReleaseDate = DateTime.Parse("2016-5-13"),
                        Genre = "FPS",
                        Price = 60.00M,
                        Number = 48
                    },
                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Doom: Eternal",
                        ReleaseDate = DateTime.Parse("2020-3-20"),
                        Genre = "FPS",
                        Price = 60.00M,
                        Number = 49
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Metal Gear V:Phantom Pain",
                        ReleaseDate = DateTime.Parse("2015-9-1"),
                        Genre = "TPS",
                        Price = 40.00M,
                        Number = 50
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Diablo III",
                        ReleaseDate = DateTime.Parse("2012-5-15"),
                        Genre = "MOAB",
                        Price = 60.00M,
                        Number = 51
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Borderlands",
                        ReleaseDate = DateTime.Parse("2009-10-20"),
                        Genre = "FPS",
                        Price = 60.00M,
                        Number = 52
                    },
                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Borderlands 2",
                        ReleaseDate = DateTime.Parse("2012-9-18"),
                        Genre = "FPS",
                        Price = 60.00M,
                        Number = 53
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Assassin's Creed: Brotherhood",
                        ReleaseDate = DateTime.Parse("2010-11-16"),
                        Genre = "TPS",
                        Price = 60.00M,
                        Number = 54
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Fallout 3",
                        ReleaseDate = DateTime.Parse("2008-10-28"),
                        Genre = "FPS",
                        Price = 60.00M,
                        Number = 55
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Fallout 4",
                        ReleaseDate = DateTime.Parse("2015-11-10"),
                        Genre = "FPS",
                        Price = 60.00M,
                        Number = 56
                    },
                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Titanfall",
                        ReleaseDate = DateTime.Parse("2014-3-11"),
                        Genre = "TPS",
                        Price = 60.00M,
                        Number = 57
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Titanfall 2",
                        ReleaseDate = DateTime.Parse("2016-10-28"),
                        Genre = "TPS",
                        Price = 60.00M,
                        Number = 58
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Resident Evil 2",
                        ReleaseDate = DateTime.Parse("1998-1-21"),
                        Genre = "TPS",
                        Price = 30.00M,
                        Number = 59
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Resident Evil 3",
                        ReleaseDate = DateTime.Parse("1999-9-22"),
                        Genre = "TPS",
                        Price = 30.00M,
                        Number = 60
                    },
                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Resident Evil 4",
                        ReleaseDate = DateTime.Parse("2005-1-11"),
                        Genre = "TPS",
                        Price = 40.00M,
                        Number = 61
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Resident Evil 5",
                        ReleaseDate = DateTime.Parse("2009-3-5"),
                        Genre = "TPS",
                        Price = 60.00M,
                        Number = 62
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Resident Evil 6",
                        ReleaseDate = DateTime.Parse("2012-10-2"),
                        Genre = "TPS",
                        Price = 60.00M,
                        Number = 63
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Resident Evil 7",
                        ReleaseDate = DateTime.Parse("2017-1-24"),
                        Genre = "TPS",
                        Price = 60.00M,
                        Number = 64
                    },
                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Resident Evil: Village",
                        ReleaseDate = DateTime.Parse("2021-5-7"),
                        Genre = "TPS",
                        Price = 60.00M,
                        Number = 65
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Dark Souls",
                        ReleaseDate = DateTime.Parse("2011-9-22"),
                        Genre = "TPS",
                        Price = 60.00M,
                        Number = 66
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Dark Souls II",
                        ReleaseDate = DateTime.Parse("2014-3-11"),
                        Genre = "TPS",
                        Price = 60.00M,
                        Number = 67
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Fable",
                        ReleaseDate = DateTime.Parse("2004-9-14"),
                        Genre = "TPS",
                        Price = 30.00M,
                        Number = 68
                    },
                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Fable II",
                        ReleaseDate = DateTime.Parse("2008-10-21"),
                        Genre = "TPS",
                        Price = 60.00M,
                        Number = 69
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Fable III",
                        ReleaseDate = DateTime.Parse("2010-10-26"),
                        Genre = "TPS",
                        Price = 60.00M,
                        Number = 70
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Super Smash Bros.",
                        ReleaseDate = DateTime.Parse("1999-1-21"),
                        Genre = "Brawler",
                        Price = 40.00M,
                        Number = 71
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Super Smash Bros.: Brawl",
                        ReleaseDate = DateTime.Parse("2008-2-10"),
                        Genre = "Brawler",
                        Price = 40.00M,
                        Number = 72
                    },
                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Super Smash Bros.: Ultimate",
                        ReleaseDate = DateTime.Parse("2018-12-7"),
                        Genre = "Brawler",
                        Price = 40.00M,
                        Number = 73
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "The Sims III",
                        ReleaseDate = DateTime.Parse("2009-6-2"),
                        Genre = "Simulator",
                        Price = 60.00M,
                        Number = 74
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "The Sims 4",
                        ReleaseDate = DateTime.Parse("2014-9-2"),
                        Genre = "Simulator",
                        Price = 60.00M,
                        Number = 75
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Rise of the Tomb Raider",
                        ReleaseDate = DateTime.Parse("2015-11-10"),
                        Genre = "TPS",
                        Price = 40.00M,
                        Number = 76
                    },
                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Dishonored",
                        ReleaseDate = DateTime.Parse("2012-10-9"),
                        Genre = "TPS",
                        Price = 40.00M,
                        Number = 77
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Dishonored II",
                        ReleaseDate = DateTime.Parse("2016-11-11"),
                        Genre = "TPS",
                        Price = 40.00M,
                        Number = 78
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Apex Legends",
                        ReleaseDate = DateTime.Parse("2019-2-4"),
                        Genre = "Battle Royale",
                        Price = 0.00M,
                        Number = 79
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Hollow Knight",
                        ReleaseDate = DateTime.Parse("2017-2-24"),
                        Genre = "Side Scroller",
                        Price = 20.00M,
                        Number = 80
                    },
                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Counter Strike:GO",
                        ReleaseDate = DateTime.Parse("2012-8-21"),
                        Genre = "FPS",
                        Price = 0.00M,
                        Number = 81
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Left For Dead",
                        ReleaseDate = DateTime.Parse("2008-11-17"),
                        Genre = "FPS",
                        Price = 40.00M,
                        Number = 82
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Left For Dead II",
                        ReleaseDate = DateTime.Parse("2009-11-17"),
                        Genre = "FPS",
                        Price = 60.00M,
                        Number = 83
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "EarthBound",
                        ReleaseDate = DateTime.Parse("1994-8-27"),
                        Genre = "Survival",
                        Price = 20.00M,
                        Number = 84
                    },
                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Pokemon Yellow",
                        ReleaseDate = DateTime.Parse("1998-9-12"),
                        Genre = "Turn Based Combat",
                        Price = 20.00M,
                        Number = 85
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Metal Gear Solid 3: Snake Eater",
                        ReleaseDate = DateTime.Parse("2004-11-17"),
                        Genre = "TPS",
                        Price = 40.00M,
                        Number = 86
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Undertale",
                        ReleaseDate = DateTime.Parse("2015-9-15"),
                        Genre = "Adventure",
                        Price = 0.00M,
                        Number = 87
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Half-Life: Alyx",
                        ReleaseDate = DateTime.Parse("2020-3-23"),
                        Genre = "FPS",
                        Price = 60.00M,
                        Number = 88
                    },
                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "BioShock",
                        ReleaseDate = DateTime.Parse("2007-8-21"),
                        Genre = "FPS",
                        Price = 60.00M,
                        Number = 89
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Fortnite",
                        ReleaseDate = DateTime.Parse("2017-7-21"),
                        Genre = "Battle Royale",
                        Price = 40.00M,
                        Number = 90
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "The Sims 2",
                        ReleaseDate = DateTime.Parse("2004-9-14"),
                        Genre = "Simulator",
                        Price = 40.00M,
                        Number = 91
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Call of Duty: Infinate Warfare",
                        ReleaseDate = DateTime.Parse("2016-11-4"),
                        Genre = "FPS",
                        Price = 60.00M,
                        Number = 92
                    },
                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Call of Duty: Advanced Warfare",
                        ReleaseDate = DateTime.Parse("2014-11-4"),
                        Genre = "FPS",
                        Price = 60.00M,
                        Number = 93
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Call of Duty: Ghosts",
                        ReleaseDate = DateTime.Parse("2013-11-5"),
                        Genre = "FPS",
                        Price = 60.00M,
                        Number = 94
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Assassin's Creed: Black Flag",
                        ReleaseDate = DateTime.Parse("2013-10-29"),
                        Genre = "TPS",
                        Price = 60.00M,
                        Number = 95
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Assassin's Creed: Valhalla",
                        ReleaseDate = DateTime.Parse("2020-11-10"),
                        Genre = "TPS",
                        Price = 60.00M,
                        Number = 96
                    },
                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Far Cry 5",
                        ReleaseDate = DateTime.Parse("2018-3-27"),
                        Genre = "FPS",
                        Price = 60.00M,
                        Number = 97
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Far Cry 4",
                        ReleaseDate = DateTime.Parse("2014-11-18"),
                        Genre = "FPS",
                        Price = 60.00M,
                        Number = 98
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Far Cry 3",
                        ReleaseDate = DateTime.Parse("2012-11-29"),
                        Genre = "FPS",
                        Price = 60.00M,
                        Number = 99
                    },

                    new Best.Videogames.Models.VideoGame
                    {
                        Title = "Battlefield 2042",
                        ReleaseDate = DateTime.Parse("2021-11-19"),
                        Genre = "FPS",
                        Price = 60.00M,
                        Number = 100
                    }                    
                );
                context.SaveChanges();
            }
        }
    }
}