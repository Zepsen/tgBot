// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Bot.Core.Bll.Commands;
using EmptyBot1.Bll;
using EmptyBot1.Bll.Commands;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;

namespace Bot.Core
{
    public class BotHandler : ActivityHandler
    {
        public static List<string> Data = new List<string>();

        protected override async Task OnMembersAddedAsync(IList<ChannelAccount> membersAdded, ITurnContext<IConversationUpdateActivity> turnContext, CancellationToken cancellationToken)
        {
            foreach (var member in membersAdded)
            {
                if (member.Id != turnContext.Activity.Recipient.Id)
                {
                    await turnContext.SendActivityAsync(MessageFactory.Text($"Hello world1!"), cancellationToken);
                }
            }
        }

        protected override async Task OnMessageActivityAsync(ITurnContext<IMessageActivity> turnContext, CancellationToken cancellationToken)
        {
            var invoker = new Invoker();
            ResolveCommand(turnContext, invoker);
            await invoker.Run(turnContext, cancellationToken);
        }

        private void ResolveCommand(ITurnContext<IMessageActivity> turnContext, Invoker invoker)
        {
            var cmd = turnContext.Activity.Text.Substring(0, 1);

            switch (cmd)
            {
                case "+":
                    invoker.Set(new AddNewTaskCommand());
                    break;

                case "-":
                    invoker.Set(new RemoveCommand());
                    break;

                case "!":
                    invoker.Set(new ShowListCommand());
                    break;

                default:
                    invoker.Set(new NoCommand());
                    break;
            }
        }
    }
}
