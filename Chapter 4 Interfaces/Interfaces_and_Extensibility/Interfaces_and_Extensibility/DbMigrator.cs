using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_and_Extensibility
{
    public class DbMigrator
    {
        private readonly ILogger _logger;

        //This is called dependency injection
        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }

        //Instead of talking directly to Console WriteLine we talk to the _logger
        public void Migrate()
        {
            _logger.LogInfo(String.Format("Migration started at {0}", DateTime.Now));

            //Details of migrating the database

            _logger.LogInfo(String.Format("Migration finished at {0}", DateTime.Now));

        }
    }
}
