using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace StoryBook.Data
{
    public class StoryBookContext : DbContext
    {
        public StoryBookContext() : base("StoryBook")
        {

        }

        public DbSet<Models.Character> Characters { get; set; }
        public DbSet<Models.Event> Events { get; set; }
        public DbSet<Models.Item> Items { get; set; }
        public DbSet<Models.Location> Locations { get; set; }
    }
}