using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;
using System;
using System.Threading;
using System.Threading.Tasks;
using Bot.BLL.Interfaces;
using Bot.Data;

namespace Bot.Bll.Commands
{
    public class RemoveCommand : ICommand
    {
        public async Task ExecuteAsync(ApplicationContext context, ITurnContext<IMessageActivity> turnContext, CancellationToken cancellationToken)
        {
            var value = turnContext.Activity.Text.Substring(1).Trim();
            int.TryParse(value, out var num);

            string msg;
            //if (num == 0)
            //{
            //    msg = "Wrong number";
            //}            
            //else if()
            //{
            //    msg = "No key";
            //}
            //else 
            //{
            //    msg = "Deleted " + num;
            //}
            
            await turnContext.SendActivityAsync(MessageFactory.Text("asd"), cancellationToken);
        }
    }
}
