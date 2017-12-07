using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Design_a_Database_Connection
{
    public class OracleConnection: SqlConnection
    {

        public OracleConnection(string connectionString)
            :base(connectionString)
        {

        }

        public override void OpenDbConnection()
        {
            var startTime = DateTime.Now;

            // Fake some time for connection to happen.
            Thread.Sleep(4000);

            var connectionTime = DateTime.Now - startTime;

            if (connectionTime > TimeOut)
            {
                throw new InvalidOperationException("Oracle Connection timed out");
            }

            Console.WriteLine("Oracle Connection Opened With: {0} \n Connection Established in : {1} seconds", ConnectionString , connectionTime.Seconds);
        }

        public override void CloseDbConnection()
        {
            Console.WriteLine("Oracle connection closed");
        }



    }
}
