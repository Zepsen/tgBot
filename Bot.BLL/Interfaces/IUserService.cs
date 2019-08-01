using System.Threading.Tasks;
using Bot.Data;

namespace Bot.BLL.Interfaces
{
    public interface IUserService
    {
        Task<User> GetAsync(string channeId);
        Task CreateAsync(User user);
    }
}