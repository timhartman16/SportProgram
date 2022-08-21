using System.Threading.Tasks;

namespace Infrastructure.Interfaces
{
    public interface IQuery<in TCriteria, out TResult>
    {
        TResult Execute(TCriteria criteria);
    }

    public interface IQuery<out TResult>
    {
        TResult Execute();
    }

    public interface IQueryAsync<in TCriteria, out TResult>
    {
        TResult ExecuteAsync(TCriteria criteria);
    }

    public interface IQueryAsync<out TResult>
    {
        TResult ExecuteAsync();
    }
}
