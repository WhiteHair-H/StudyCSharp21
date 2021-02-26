using System;
using System.Configuration;
using System.Data;

namespace DBConTestApp
{
    class DBhelper
    {
        public IDbConnection GetDbConnection()
        {
            IDbConnection dbConn = null;
            string connString = ConfigurationManager.AppSettings["Connection"];
            var DBType = ConfigurationManager.AppSettings["DbType"];
            switch (DBType)
            {
                case "SQLServer":
                    dbConn = new SqlConnection(connString);
                    break;
                case"Oracle":
                    dbConn = new Oracleconnection(connString);
                    break;
                case "OleDB":
                    dbConn = new OleDbConnection(connString);
                    break;
                default:
                    break;

            }
            
            
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
