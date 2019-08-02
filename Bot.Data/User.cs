using System;
using System.Collections.Generic;

namespace Bot.Data
{
    public class User
    {
        public int Id { get; set; }
        public string ChannelAccountId { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }

        
        public ICollection<UsersItems> UsersItems { get; set; }

    }
}
