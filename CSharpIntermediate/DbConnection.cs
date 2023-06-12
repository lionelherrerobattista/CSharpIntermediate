using System;

namespace CSharpIntermediate
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        public DbConnection(string connectionString)
        {
            // case null or empty string
            if (String.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentNullException("connectionString");
                    
            ConnectionString = connectionString;
        }

        public abstract void OpenConnection();
        public abstract void CloseConnection();
    }
}
