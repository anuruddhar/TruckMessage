using System;
using System.Collections.Generic;
using System.Text;

namespace TruckMessage.Public.Results {
    public class TruckMessageResult {
        public int CosignmentNumber { get; set; }
        public DateTime DateTime { get; set; }
        public string UserId { get; set; }
        public string PdtNumber { get; set; }
        public string Message { get; set; }
    }
}
