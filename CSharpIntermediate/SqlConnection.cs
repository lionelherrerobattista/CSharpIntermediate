using System;

namespace CSharpIntermediate
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString)
            : base(connectionString)
        { }

        public override void OpenConnection()
        {
            Console.WriteLine("SQL connection opened!");
        }
        public override void CloseConnection()
        {
            Console.WriteLine("Sql connection closed!");
        }
    }
}
