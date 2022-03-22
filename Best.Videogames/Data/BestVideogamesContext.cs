#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Best.Videogames.Models;

namespace Best.Videogames.Data
{
    public class BestVideogamesContext : DbContext
    {
        public BestVideogamesContext (DbContextOptions<BestVideogamesContext> options)
            : base(options)
        {
        }

        public DbSet<Best.Videogames.Models.VideoGame> VideoGame { get; set; }
    }
}
