using System.Threading;
using System.Threading.Tasks;
using Bot.BLL.Interfaces;
using Bot.Data;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;

namespace Bot.Bll.Commands
{
    public class NoCommand : ICommand
    {
        public async Task ExecuteAsync(ApplicationContext context, ITurnContext<IMessageActivity> turnContext, CancellationToken cancellationToken)
        {            
            await turnContext.SendActivityAsync(MessageFactory.Text($"No command specify"), cancellationToken);
        }
    }
}
