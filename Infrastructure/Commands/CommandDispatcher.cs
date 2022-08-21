using Microsoft.Extensions.DependencyInjection;
using Infrastructure.Interfaces;
using System;
using System.Threading.Tasks;

namespace Infrastructure.Commands
{
    public class CommandDispatcher : ICommandDispatcher
    {
        private IServiceProvider _serviceProvider;

        public CommandDispatcher(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void Handle<TCommand>(TCommand command)
        {
            _serviceProvider.GetService<IHandle<TCommand>>()?.Handle(command);
        }

        public TResult Handle<TCommand, TResult>(TCommand command)
        {
            var handler = _serviceProvider.GetService<IHandle<TCommand, TResult>>();
            var result = handler.Handle(command);

            return result;
        }
        public async Task HandleAsync<TCommand>(TCommand command)
        {
            var handler = _serviceProvider.GetService<IHandleAsync<TCommand>>();
            await handler.HandleAsync(command);
        }
    }
}
