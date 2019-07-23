using EmptyBot1.Commands;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;
using System.Threading;
using System.Threading.Tasks;

namespace EmptyBot1.Bll.Commands
{
    public class AddNewTaskCommand : ICommand
    {
        public async Task ExecuteAsync(ITurnContext<IMessageActivity> turnContext, CancellationToken cancellationToken)
        {
            var text = turnContext.Activity.Text;
            Bot.Data.Add(text.Substring(1));
            await turnContext.SendActivityAsync(MessageFactory.Text($"Add command: " + turnContext.Activity.Text), cancellationToken);
        }
    }
}
