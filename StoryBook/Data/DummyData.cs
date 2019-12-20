using StoryBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoryBook.Data
{
    public class DummyData
    {
        public List<Character> GetCharacters()
        {
            List<Character> characters = new List<Character>()
            {
                new Character()
                {
                    Name="Bob",
                    DOB="27/08/1996",
                    Personalty="Passive",
                    Apperance="Tall"
                }

            };
            return characters;
        }
        private List<Event> GetEvents()
        {
            List<Event> events = new List<Event>()
            {
                new Event
                {
                    EventName="Lint civil war",
                    EventDate="12/12/2024",
                    EventDescription="First and second prince of Lint fight over the Crown"
                }

            };
            return events;
        }
        private List<Location> GetLocations()
        {
            List<Location> locations = new List<Location>()
            {
                new Location
                {
                    LocationName="Lint",
                    LocationType="Kingdom",
                    LocationDescription="Words oldest known kingdom"
                }

            };
            return locations;
        }
        private List<Item> GetItems()
        {
            List<Item> items= new List<Item>()
            {
                new Item
                {
                    ItemName="Lint treasury key",
                    ItemDecsription="key to lint kindoms treasury",
                    ItemOwner="Bob"
                }

            };
            return items;
        }
    }
}