using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;
using System.Threading;
using System.Threading.Tasks;

namespace EmptyBot1.Commands
{
    public class Invoker
    {
        ICommand _command;
        public void Set(ICommand command) => _command = command;
        public async Task Run(ITurnContext<IMessageActivity> turnContext, CancellationToken cancellationToken)
            => await _command.ExecuteAsync(turnContext, cancellationToken);
        
    }
}
