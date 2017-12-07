using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Design_a_Database_Connection
{
    public class SqlConnection : DbConnection
    {

        public SqlConnection(string connectionString)
            :base(connectionString)
        {

        }

        public override void OpenDbConnection()
        {
            var startTime = DateTime.Now;

            Console.WriteLine("Opening SQL Connection");

            // Fake some time for connection to happen.
            Thread.Sleep(4000);

            var connectionTime = DateTime.Now - startTime;

            if (connectionTime > TimeOut)
            {
                throw new InvalidOperationException("SQL Connection timed out");
            }

            Console.WriteLine("SQL Connection Opened With: {0}\n Connection Established in : {1} seconds", ConnectionString , connectionTime.Seconds);
        }


        public override void CloseDbConnection()
        {
            Console.WriteLine("Sql connection closed");
        }


    }
}
