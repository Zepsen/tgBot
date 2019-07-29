using System.Threading;
using System.Threading.Tasks;
using EmptyBot1.Commands;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;

namespace EmptyBot1.Bll
{
    public class Invoker
    {
        private ICommand _command;
        public void Set(ICommand command) => _command = command;
        public async Task Run(ITurnContext<IMessageActivity> turnContext, CancellationToken cancellationToken)
            => await _command.ExecuteAsync(turnContext, cancellationToken);
        
    }
}
