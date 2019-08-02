namespace Bot.Data
{
    public class UsersItems
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int TaskId { get; set; }
        public Item Item { get; set; }
    }
}