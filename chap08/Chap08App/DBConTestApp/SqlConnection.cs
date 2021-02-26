using System.Data;

namespace DBConTestApp
{
    internal class SqlConnection : IDbConnection
    {
        private string connString;

        public SqlConnection(string connString)
        {
            this.connString = connString;
        }
    }
}