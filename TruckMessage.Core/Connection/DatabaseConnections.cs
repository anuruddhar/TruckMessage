using System;
using System.Collections.Generic;
using System.Text;

namespace TruckMessage.Core.Connection {
    public class DatabaseConnections {
        public string CommandConnection { get; set; }
        public string QueryConnection { get; set; }
        public string SecurityConnection { get; set; }
        public string OracleConnection { get; set; }
        public string ReportConnection { get; set; }
        public string ErrorConnection { get; set; }
    }
}
