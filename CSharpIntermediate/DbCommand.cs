using System;

namespace CSharpIntermediate
{
    public class DbCommand
    {
        private readonly DbConnection _dbConnection;
        private readonly string _instruction;

        public DbCommand(DbConnection dbConnection, string instruction) 
        {
            string variableName;

            if (dbConnection == null || String.IsNullOrWhiteSpace(instruction))
            {
                variableName = dbConnection == null ? nameof(dbConnection) : nameof(instruction);
                throw new ArgumentNullException(variableName);
            }
            
            _dbConnection = dbConnection;
            _instruction = instruction;
        }

        public void Execute() 
        {
            _dbConnection.OpenConnection();
            Console.WriteLine("Running instruction: {0}", _instruction);
            _dbConnection.CloseConnection();
        }



    }
}
