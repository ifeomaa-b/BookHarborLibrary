using E_commerce.Models.Models;
using E_Commerce.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Security.Policy;

namespace E_Commerce.Data
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Genre> Genres { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }

        //protected override void  OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
           
            //modelBuilder.Entity<Genre>().HasData(

            //    new Genre { Id = 1, Name="Action", DisplayOrder =1},
            //    new Genre { Id = 2, Name = "Scifi", DisplayOrder = 2 },
            //    new Genre { Id = 3, Name = "History", DisplayOrder = 3 }

            //    );

            //modelBuilder.Entity<Book>().HasData(

            //    new Book
            //    {
            //        Id = 1,
            //        Title = "Fortune of Time",
            //        Author = "Billy Spark",
            //        Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
            //        ISBN = "SWD9999001",
            //        Publisher = "Gemma Code Press",
            //        PublishedDate = new DateTime(2002, 1, 3),
            //        TotalPageCount = 178,
            //        GenreId = 1,
            //        ImageUrl = ""

            //    },
            //    new Book
            //    {
            //        Id = 2,
            //        Title = "Dark Skies",
            //        Author = "Nancy Hoover",
            //        Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
            //        ISBN = "CAW777777701",
            //        Publisher = "New York",
            //        PublishedDate = new DateTime(2002, 1, 3),
            //        TotalPageCount= 178,
            //        GenreId = 2,
            //        ImageUrl = ""

            //    },
            //    new Book
            //    {
            //        Id = 3,
            //        Title = "Vanish in the Sunset",
            //        Author = "Julian Button",
            //        Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
            //        ISBN = "RITO5555501",
            //        Publisher = "Kelvin Press",
            //        PublishedDate = new DateTime(2013, 09, 29),
            //        TotalPageCount = 190,
            //        GenreId = 1,
            //        ImageUrl = ""
            //    },
            //    new Book
            //    {
            //        Id = 4,
            //        Title = "Cotton Candy",
            //        Author = "Abby Muscles",
            //        Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
            //        ISBN = "WS3333333301",
            //        Publisher = "Sabinus Press",
            //        PublishedDate = new DateTime(2014, 5, 31),
            //        TotalPageCount = 130,
            //        GenreId = 3,
            //        ImageUrl = ""
            //    },
            //    new Book
            //    {
            //        Id = 5,
            //        Title = "Rock in the Ocean",
            //        Author = "Ron Parker",
            //        Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
            //        ISBN = "SOTJ1111111101",
            //        Publisher = "Mazium Press",
            //        PublishedDate = new DateTime(2016, 2, 3),
            //        TotalPageCount = 1728,
            //        GenreId = 1,
            //        ImageUrl = ""
            //    },
            //    new Book
            //    {
            //        Id = 6,
            //        Title = "Leaves and Wonders",
            //        Author = "Laura Phantom",
            //        Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
            //        ISBN = "FOT000000001",
            //        Publisher = "Gemma Press",
            //        PublishedDate = new DateTime(2019,12,3),
            //        TotalPageCount = 178,
            //        GenreId = 2,
            //        ImageUrl = ""
            //    }); 
        //}

    }
}
