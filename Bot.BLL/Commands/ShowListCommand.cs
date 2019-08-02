using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Bot.BLL.Interfaces;
using Bot.Data;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bot.Bll.Commands
{
    public class ShowListCommand : ICommand
    {
        public async Task ExecuteAsync(ApplicationContext context, ITurnContext<IMessageActivity> turnContext, CancellationToken cancellationToken)
        {
            var items = await context.Users.AsNoTracking()
                .Where(i => i.ChannelAccountId == turnContext.Activity.Recipient.Id)
                .SelectMany(i => i.UsersItems)
                .ToListAsync(cancellationToken: cancellationToken);
            
            await turnContext.SendActivityAsync(MessageFactory.Text("asdf"), cancellationToken);
        }
    }
}
