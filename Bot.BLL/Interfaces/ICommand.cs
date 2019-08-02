using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;
using System.Threading;
using System.Threading.Tasks;
using Bot.Data;

namespace Bot.BLL.Interfaces
{
    public interface ICommand
    {
        Task ExecuteAsync(ApplicationContext context, ITurnContext<IMessageActivity> turnContext, CancellationToken cancellationToken);
    }
}
