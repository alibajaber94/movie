using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieWebsite.Models;

namespace MovieWebsite.Data
{
    public class MovieWebsiteContext : DbContext
    {
        public MovieWebsiteContext (DbContextOptions<MovieWebsiteContext> options)
            : base(options)
        {
        }

        public DbSet<MovieWebsite.Models.Movie> Movie { get; set; } = default!;
    }
}
