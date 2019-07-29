using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using EmptyBot1.Commands;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;

namespace Bot.Core.Bll.Commands
{
    public class ShowListCommand : ICommand
    {
        public async Task ExecuteAsync(ITurnContext<IMessageActivity> turnContext, CancellationToken cancellationToken)
        {
            var arr = BotHandler.Data.Select((i, n) => $"{n + 1} - {i}").ToArray();
            var msg = string.Join("\r\n", arr);
            await turnContext.SendActivityAsync(MessageFactory.Text(msg), cancellationToken);
        }
    }
}
