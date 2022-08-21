using System.Threading.Tasks;

namespace Infrastructure.Interfaces
{
    public interface IHandle<in TCommand>
    {
        void Handle(TCommand command);
    }
    public interface IHandle<in TCommand, out TResult>
    {
        TResult Handle(TCommand command);
    }

    public interface IHandleAsync<in TCommand>
    {
        Task HandleAsync(TCommand command);
    }
}
