using System.Data;

namespace ApacheIgniteExample.Infrastructure.Datacontext
{
    public interface IOracleDataContext
    {
        IDbConnection GetConnection();
    }
}
