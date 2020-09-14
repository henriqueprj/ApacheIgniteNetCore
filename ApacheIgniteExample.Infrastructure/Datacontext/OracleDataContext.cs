using Microsoft.Extensions.Configuration;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace ApacheIgniteExample.Infrastructure.Datacontext
{
    public class OracleDataContext : IOracleDataContext
    {
        private readonly IConfiguration _configutarion;

        public OracleDataContext(IConfiguration configutarion)
        {
            _configutarion = configutarion;
        }

        public IDbConnection GetConnection()
        {
            return new OracleConnection(ConfigurationExtensions
                            .GetConnectionString(configuration: _configutarion, name: "OracleConnectionString"));
        }
    }
}
