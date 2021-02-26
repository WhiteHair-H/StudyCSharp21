using System.Data;

namespace DBConTestApp
{
    internal class Oracleconnection : IDbConnection
    {
        private string connString;

        public Oracleconnection(string connString)
        {
            this.connString = connString;
        }
    }
}