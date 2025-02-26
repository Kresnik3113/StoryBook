﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoryBook.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public string EventName { get; set; }
        public string EventDate { get; set; }
        public string EventDescription { get; set; }
        public virtual ICollection<Character> Characters { get; set; }
        public virtual ICollection<Item> Items { get; set; }

    }
}