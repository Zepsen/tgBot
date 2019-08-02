using System;
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
    public class AddNewTaskCommand : ICommand
    {
        public async Task ExecuteAsync(ApplicationContext context, ITurnContext<IMessageActivity> turnContext, CancellationToken cancellationToken)
        {
            var text = turnContext.Activity.Text;
            
            var user = await context.Users.FirstOrDefaultAsync(i => i.ChannelAccountId == turnContext.Activity.Recipient.Id, cancellationToken: cancellationToken);

            var item = new Item
            {
                DateAdded = DateTime.UtcNow,
                DateUpdated = DateTime.UtcNow,
                Value = text
            };

            await context.Items.AddAsync(item, cancellationToken);
            await context.SaveChangesAsync(cancellationToken);

            user.UsersTasks.Add(new UsersItems { UserId = user.Id, ItemId = item.Id });
            await context.SaveChangesAsync(cancellationToken);

            await turnContext.SendActivityAsync(MessageFactory.Text($"Add command: " + turnContext.Activity.Text), cancellationToken);
        }
    }
}
