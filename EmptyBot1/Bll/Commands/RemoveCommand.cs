using EmptyBot1.Commands;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace EmptyBot1.Bll.Commands
{
    public class RemoveCommand : ICommand
    {
        public async Task ExecuteAsync(ITurnContext<IMessageActivity> turnContext, CancellationToken cancellationToken)
        {
            var value = turnContext.Activity.Text.Substring(1).Trim();
            int.TryParse(value, out var num);

            string msg;
            if (num == 0)
            {
                msg = "Wrong number";
            }            
            else if(Bot.Core.BotHandler.Data.Count < num)
            {
                msg = "No key";
            }
            else 
            {
                Bot.Core.BotHandler.Data.RemoveAt(num - 1);
                msg = "Deleted " + num;
            }
            
            await turnContext.SendActivityAsync(MessageFactory.Text(msg), cancellationToken);
        }
    }
}
