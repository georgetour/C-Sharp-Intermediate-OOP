using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_a_Database_Connection
{
    public class DbCommand:DbConnection
    {
        public DbConnection _newConnection { get; set; }
        public string _dbCommand { get; set; }

        public DbCommand(DbConnection newConnection,string connectionString,string dbCommand)
            :base(connectionString)
        {
            _newConnection = newConnection;
            _dbCommand = dbCommand;
        }

        public override void OpenDbConnection()
        {
            
        }

        public override void CloseDbConnection()
        {

        }
        
        //With the Execute we are saying first to OpenDbConnecion 
        //to the one we want which is a parameter in
        //the constructor, example SqlConnection or OracleConnection after we have created them
        //as new objects, then we pass a parameter which will be the command 
        //and finally we close the connection to current Database
        public void Execute()
        {
            _newConnection.OpenDbConnection();
            Console.WriteLine(_dbCommand);
            _newConnection.CloseDbConnection();

        }





    }
}
