using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    class Program
    {
        static void Main(string[] args)
        {

            var dbMigrator = new DbMigrator(new Logger());

            //Or we can create an new Logger and pass it as the arguments
            var logger = new Logger();
            var installer = new Installer(logger);

            dbMigrator.Migrate();

            installer.Install();



        }
    }
}
