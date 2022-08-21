using System.Threading.Tasks;

namespace Infrastructure.Interfaces
{
    public interface ICommandDispatcher
    {
        void Handle<TCommand>(TCommand command);
        TResult Handle<TCommand, TResult>(TCommand command);
        Task HandleAsync<TCommand>(TCommand command);
    }
}
