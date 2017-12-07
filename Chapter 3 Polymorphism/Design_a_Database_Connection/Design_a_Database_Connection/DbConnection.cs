using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Design_a_Database_Connection
{
    public abstract class DbConnection
    {

        public string ConnectionString { get; set; }
        public TimeSpan TimeOut { get; set; }


        public DbConnection(string connectionstring)
        {
            if (String.IsNullOrWhiteSpace(connectionstring))
                throw new InvalidOperationException("dbconnection can't be empty");
            else
                //According to these seconds we will get an error if they are smaller
                //than Thread.Sleep in our derived classes
                TimeOut = new TimeSpan(0,0,5); //hours, minutes, seconds
                this.ConnectionString = connectionstring;
        }
        

        public abstract void OpenDbConnection();

        public abstract void CloseDbConnection();


        





    }
}
