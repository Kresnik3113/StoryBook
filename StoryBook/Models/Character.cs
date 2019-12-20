using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoryBook.Models
{
    public class Character
    {
        public int CharacterId { get; set; }
        public string Name { get; set; }
        public string DOB { get; set; }
        public string Personalty { get; set; }
        public string Apperance { get; set; }
        public virtual ICollection<Event> Events { get; set; }


    }
}