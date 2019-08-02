using System.Threading;
using System.Threading.Tasks;
using Bot.BLL.Interfaces;
using Bot.Data;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;

namespace EmptyBot1.Bll
{
    public class Invoker
    {
        private ICommand _command;
        public void Set(ICommand command) => _command = command;
        public async Task Run(ApplicationContext context, ITurnContext<IMessageActivity> turnContext, CancellationToken cancellationToken)
            => await _command.ExecuteAsync(context, turnContext, cancellationToken);
        
    }
}
