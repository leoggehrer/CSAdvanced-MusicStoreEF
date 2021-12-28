using Bogus;
using MusicStoreEF.Logic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MusicStoreEF.ConApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("MusicStore system with EntityFramework!");

            ClearAll();
            GenerateData();
        }
        static void ClearAll()
        {
            using var dbContext = new Logic.DataContext.MusicDbContext();

            dbContext.ArtistSet.RemoveRange(dbContext.ArtistSet);
            dbContext.AlbumSet.RemoveRange(dbContext.AlbumSet);
            dbContext.SaveChanges();
        }
        static void GenerateData()
        {
            using var dbContext = new Logic.DataContext.MusicDbContext();

            var testArtists = new Faker<Artist>()
                .RuleFor(e => e.Name, f => f.Name.FullName());

            var artists = testArtists.Generate(250);
            dbContext.ArtistSet.AddRange(artists);

            dbContext.SaveChanges();

            using var dbContext2 = new Logic.DataContext.MusicDbContext();
            var albums = new List<Album>();

            foreach (var artist in artists)
            {
                var creator = new Faker<Album>()
                    .RuleFor(e => e.ArtistId, f => artist.Id)
                    .RuleFor(e => e.Title, f => string.Join(' ', f.Lorem.Words(10)));
                albums.AddRange(creator.Generate(10));
            }
            dbContext2.AlbumSet.AddRange(albums);
            dbContext2.SaveChanges();

        }

    }
}