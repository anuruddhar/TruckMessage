using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using TruckMessage.Core.Connection;

namespace TruckMessage.Core.DataAccess {
    public class Database : IDatabase {

        private readonly ConnectionStrings _connectionStrings;
        private readonly int _commandTimeout;



        public SqlConnection GetCommandConnection() {
            return new SqlConnection(_connectionStrings.CommandsConnectionString);
        }

        public SqlConnection GetQueryConnection() {
            return new SqlConnection(_connectionStrings.QueriesConnectionString);
        }

        public SqlConnection GetSecurityConnection() {
            return new SqlConnection(_connectionStrings.SecurityConnectionString);
        }

        public SqlConnection GetErrorDbConnection() {
            return new SqlConnection(_connectionStrings.ErrorConnectionString);
        }

        public OracleConnection GetOracleConnection() {
            return new OracleConnection(_connectionStrings.OracleConnection);
        }

    }
}
