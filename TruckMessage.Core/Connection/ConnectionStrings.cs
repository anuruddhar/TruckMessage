using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using TruckMessage.Core.Encrypter;
using TruckMessage.Core.Service.UserHelper;

namespace TruckMessage.Core.Connection {
    public sealed class ConnectionStrings {
        private readonly IEncrypter _encrypter;
        private readonly IUserHelper _userHelper;
        private string _commandsConnectionString;
        private string _queriesConnectionString;
        private string _securityConnectionString;
        private string _errorConnectionString;
        private string _userId = string.Empty;
        private string _workstationId = string.Empty;
        private int _connectionTimeOut = 30;
        IOptions<DatabaseConnections> _databaseConnectionOptions;

        public ConnectionStrings(IEncrypter encrypter, IUserHelper userHelper, IOptions<DatabaseConnections> databaseConnectionOptions) {
            _encrypter = encrypter;
            _userHelper = userHelper;
            _databaseConnectionOptions = databaseConnectionOptions;


            _userId = _userHelper.GetUsernameWithDomain();
            _workstationId = _userHelper.GetWorkstation();
        }
            

        public string CommandsConnectionString {
            get {
                if (string.IsNullOrEmpty(_commandsConnectionString))
                    _commandsConnectionString = GetConnection(_databaseConnectionOptions.Value.CommandConnection);

                return _commandsConnectionString;
            }
        }
        public string QueriesConnectionString {
            get {
                if (string.IsNullOrEmpty(_queriesConnectionString))
                    _queriesConnectionString = GetConnection(_databaseConnectionOptions.Value.QueryConnection);

                return _queriesConnectionString;
            }
        }
        public string SecurityConnectionString {
            get {
                if (string.IsNullOrEmpty(_securityConnectionString))
                    _securityConnectionString = GetConnection(_databaseConnectionOptions.Value.SecurityConnection);

                return _securityConnectionString;
            }
        }

        public string ErrorConnectionString {
            get {
                if (string.IsNullOrEmpty(_errorConnectionString))
                    _errorConnectionString = GetConnection(_databaseConnectionOptions.Value.ErrorConnection);

                return _errorConnectionString;
            }
        }

        public string OracleConnection { get; set; }



        private string GetConnection(string connectionString) {
            var planConnectionString = _encrypter.Decrypt(connectionString);
            SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder(planConnectionString);
            sqlConnectionStringBuilder.WorkstationID = _workstationId;
            sqlConnectionStringBuilder.ConnectTimeout = _connectionTimeOut;
            sqlConnectionStringBuilder.UserID = _userId;
            return sqlConnectionStringBuilder.ToString();
        }

        /*
        private string FullConnectionString {
            get {
                SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder(ConnectionString);
                sqlConnectionStringBuilder.WorkstationID = WorkstationId;
                sqlConnectionStringBuilder.ConnectTimeout = _connectionTimeOut;
                return sqlConnectionStringBuilder.ToString();
            }
        }
        */

    }
}
