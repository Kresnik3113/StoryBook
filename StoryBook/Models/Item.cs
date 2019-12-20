using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoryBook.Models
{
    public class Item
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public string ItemDecsription { get; set; }
        public string ItemOwner { get; set; }
        public virtual ICollection<Event> Events { get; set; }
    }
}