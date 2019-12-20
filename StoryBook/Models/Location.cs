using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoryBook.Models
{
    public class Location
    {
        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public string LocationType { get; set; }
        public string LocationDescription { set; get; }
        public virtual ICollection<Character> Characters { get; set; }
    }
}