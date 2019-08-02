using System;
using System.Collections.Generic;

namespace Bot.Data
{
    public class Item
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateUpdated { get; set; }

        
        public ICollection<UsersItems> UsersTasks { get; set; }
    }
}