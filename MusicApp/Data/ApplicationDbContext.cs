using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MusicApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
       public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Album> Album { get; set; }
        public DbSet<Artist> Artist { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<Playlist> Playlist { get; set; }
        public DbSet<Track> Track { get; set; }


    }
}
