using EmptyBot1.Commands;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace EmptyBot1.Bll.Commands
{
    public class ShowListCommand : ICommand
    {
        public async Task ExecuteAsync(ITurnContext<IMessageActivity> turnContext, CancellationToken cancellationToken)
        {
            var arr = Bot.Data.Select((i, n) => $"{n + 1} - {i}").ToArray();
            var msg = string.Join("\r\n", arr);
            await turnContext.SendActivityAsync(MessageFactory.Text(msg), cancellationToken);
        }
    }
}
