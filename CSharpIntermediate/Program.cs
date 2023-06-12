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
            var instruction = "SELECT * FROM Users";
            var sqlConnection = new SqlConnection(connectionString);
            var oracleConnection = new OracleConnection(connectionString);
            var dbCommand = new DbCommand(sqlConnection, instruction);
            
            // Exception tests:
            //var sqlConnection = new SqlConnection(null); // exception connectionString
            //var dbCommand = new DbCommand(null, instruction); // exception dbConnection
            //var dbCommand = new DbCommand(sqlConnection, ""); // exception dbConnection

            dbCommand.Execute(); // sql connection

            // swap to Oracle
            dbCommand = new DbCommand(oracleConnection, instruction);

            dbCommand.Execute(); // oracle connection
        }
    }
}
