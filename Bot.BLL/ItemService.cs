using Bot.BLL.Interfaces;
using Bot.Data;

namespace Bot.BLL
{
    public class ItemService : IItemService
    {
        private readonly ApplicationContext _context;

        public ItemService(ApplicationContext context)
        {
            _context = context;
        }
    }
}