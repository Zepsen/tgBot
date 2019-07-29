using System.Threading;
using System.Threading.Tasks;
using EmptyBot1.Commands;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;

namespace Bot.Core.Bll.Commands
{
    public class NoCommand : ICommand
    {
        public async Task ExecuteAsync(ITurnContext<IMessageActivity> turnContext, CancellationToken cancellationToken)
        {            
            await turnContext.SendActivityAsync(MessageFactory.Text($"No command specify"), cancellationToken);
        }
    }
}
