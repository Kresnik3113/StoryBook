namespace StoryBook.Migrations.SB
{
    using StoryBook.Data;
    using StoryBook.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<StoryBook.Data.StoryBookContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\SB";
        }

        protected override void Seed(StoryBook.Data.StoryBookContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            var characters = new List<Character>();
            Character c1 = new Character();
            c1.Name = "Bob";
            c1.DOB = "27/08/1996";
            c1.Apperance = "Tall";
            c1.Personalty = "Passive";
            characters.Add(c1);

            var events = new List<Event>();
            Event e1 = new Event();
            e1.EventName= "Lint civil war";
            e1.EventDate = "12/12/2024";
            e1.EventDescription = "First and second prince of Lint fight over the Crown";
            events.Add(e1);

            var locations = new List<Location>();
            Location l1 = new Location();
            l1.LocationName = "Lint";
            l1.LocationType = "Kingdom";
            l1.LocationDescription = "Words oldest known kingdom";
            locations.Add(l1);

            var items = new List<Item>();
            Item i1 = new Item();
            i1.ItemName = "Lint treasury key";
            i1.ItemDecsription = "key to lint kindoms treasury";
            i1.ItemOwner = "Bob";
            items.Add(i1);


            foreach (var c in characters)
            {
                context.Characters.Add(c);

            }
            foreach (var e in events)
            {
                context.Events.Add(e);

            }
            foreach (var l in locations)
            {
                context.Locations.Add(l);

            }
            foreach (var i in items)
            {
                context.Items.Add(i);

            }
            context.SaveChanges();
        }
    }
}
