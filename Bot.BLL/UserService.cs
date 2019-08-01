using Bot.Data;
using System.Threading.Tasks;
using Bot.BLL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Bot.BLL
{
    public class UserService : IUserService
    {
        private readonly ApplicationContext _context;

        public UserService(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<User> GetAsync(string channeId)
        {
            return await _context.Users
                .FirstOrDefaultAsync(i => 
                    i.ChannelAccountId == channeId);
        }

        public async Task CreateAsync(User user)
        {
            await _context.Users.AddAsync(user);
        }
    }
}
