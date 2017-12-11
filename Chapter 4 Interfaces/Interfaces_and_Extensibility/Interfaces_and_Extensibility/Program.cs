using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_and_Extensibility
{
    class Program
    {
        static void Main(string[] args)
        {
            //Writes to console
            var dbmigrator = new DbMigrator(new ConsoleLogger());
            dbmigrator.Migrate();

            //Writes to log.txt file
            var dblog = new DbMigrator(new FileLogger(@"C:\Users\Giant\Documents\Visual Studio 2015\Projects\C-Sharp-Intermediate-OOP\log.txt"));
            dblog.Migrate();

            //This is refered as OCP which stands for Open Close Principle.
            //Open for extension but closed for modification

        }
    }
}
