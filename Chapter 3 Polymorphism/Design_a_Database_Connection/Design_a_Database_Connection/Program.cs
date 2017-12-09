using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_a_Database_Connection
{
    class Program
    {
        static void Main(string[] args)
        {

            var sqlConnection = new SqlConnection("localhost");
            var oracleConnection = new OracleConnection("localhost");
            var sqlCommand = new DbCommand(sqlConnection,"localhost","Executed command to sql");
            var orcaleCommand = new DbCommand(sqlConnection, "localhost", "Executed command to oracle");

            //Just some screen guding for what the use must input
            Console.WriteLine("For opening sql type: Sql connect");
            Console.WriteLine("For closing sql type: Sql close");
            Console.WriteLine("For opening oracle type: Oracle connect");
            Console.WriteLine("For closing sql type: Oracle connect");
            Console.WriteLine("For executing a command type sql command or oracle command");

            //sqlConnection.OpenDbConnection();
            //oracleConnection.OpenDbConnection();
            //sqlConnection.CloseDbConnection();
            //oracleConnection.CloseDbConnection();

            while (true)
            {
                var input = Console.ReadLine().ToLower();

                switch (input)
                {
                    case "sql connect":
                        sqlConnection.OpenDbConnection();
                        break;
                    case "sql close":
                        sqlConnection.CloseDbConnection();
                        break;
                    case "oracle connect":
                        oracleConnection.OpenDbConnection();
                        break;
                    case "oracle close":
                        oracleConnection.CloseDbConnection();
                        break;
                    case "sql command":
                        sqlCommand.Execute();
                        break;
                    case "oarcle command":
                        orcaleCommand.Execute();
                        break;


                    default:
                        return;

                }
            }





        }
    }
}
