using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var dbMigrator = new DbMigrator(new ConsoleLogger()); // concrete implementation
            var dbMigrator = new DbMigrator(new FileLogger(@"C:\Users\lion_\Desktop\workspace\c_sharp_intermediate\CSharpIntermediate\log.txt"));
            dbMigrator.Migrate();
        }
    }
}
