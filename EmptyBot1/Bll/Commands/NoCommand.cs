using EmptyBot1.Commands;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;
using System.Threading;
using System.Threading.Tasks;

namespace EmptyBot1.Bll.Commands
{
    public class NoCommand : ICommand
    {
        public async Task ExecuteAsync(ITurnContext<IMessageActivity> turnContext, CancellationToken cancellationToken)
        {            
            await turnContext.SendActivityAsync(MessageFactory.Text($"No command specify"), cancellationToken);
        }
    }
}
