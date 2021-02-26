using System.Data;

namespace DBConTestApp
{
    internal class OleDbConnection : IDbConnection
    {
        private string connString;

        public OleDbConnection(string connString)
        {
            this.connString = connString;
        }
    }
}