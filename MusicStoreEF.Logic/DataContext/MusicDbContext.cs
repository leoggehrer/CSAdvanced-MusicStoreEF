using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStoreEF.Logic.DataContext
{
    public class MusicDbContext : DbContext
    {
        private static string ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Database=MusicDb;Integrated Security=True";
        public DbSet<Entities.Artist> ArtistSet { get; set; }
        public DbSet<Entities.Album> AlbumSet { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);

            base.OnConfiguring(optionsBuilder);
        }
    }
}
