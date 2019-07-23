using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;
using System.Threading;
using System.Threading.Tasks;

namespace EmptyBot1.Commands
{
    public interface ICommand
    {
        Task ExecuteAsync(ITurnContext<IMessageActivity> turnContext, CancellationToken cancellationToken);
    }
}
