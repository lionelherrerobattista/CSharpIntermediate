using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var connectionString = "test-connection";
            var sqlConnection = new SqlConnection(connectionString);
            var oracleConnection = new OracleConnection(connectionString);

            sqlConnection.OpenConnection();
            sqlConnection.CloseConnection();

            oracleConnection.OpenConnection();
            oracleConnection.CloseConnection();
        }
    }
}
