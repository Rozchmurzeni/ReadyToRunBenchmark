using System;
using System.Collections.Generic;
using Dependencies.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace Dependencies.Database
{
    public class MyContext : DbContext
    {
        public DbSet<Item> Items { get; set; }

        public MyContext() {}
        public MyContext(DbContextOptions options) : base(options) {}

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=" + DatabaseConfig.DbFilePath);

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>().HasData(GenerateData());
        }

        private Item[] GenerateData()
        {
            var items = new List<Item>();
            
            for (var i = 1; i <= 100; i++)
            {
                var item = new Item
                {
                    Id = i,
                    Text = Guid.NewGuid().ToString(),
                    CreationDateTime = DateTime.Now
                };
                items.Add(item);
            }

            return items.ToArray();
        }
    }
}
