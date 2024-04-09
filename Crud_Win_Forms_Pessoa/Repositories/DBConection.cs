using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_Crud.Repositories
{
    internal class DBConection : IDisposable
    {
        private const string ConnectionString = "Server=salt.db.elephantsql.com;Database=uenjsklh;Port=5432;Username=uenjsklh;Password=9Kc9J0DFJBNsSluO2gaHrkiqreECF8j7;";
        private readonly IDbConnection _connection;

        public DBConection()
        {
            _connection = new NpgsqlConnection(ConnectionString);
            //postgres://uenjsklh:9Kc9J0DFJBNsSluO2gaHrkiqreECF8j7@salt.db.elephantsql.com/uenjsklh
        }

        public void Dispose()
        {
            _connection.Dispose();
        }

        public IDbConnection GetConnection()
        {
            if( _connection.State != ConnectionState.Open )
                _connection.Open();
            
            return _connection;
        }
    }
}
