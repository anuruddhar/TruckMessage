using System;
using System.Collections.Generic;
using System.Text;
using TruckMessage.Core.Cqrs;

namespace TruckMessage.Public.Commands {
    public class TruckMessageSaveCommand : ICommand {
        public int CosignmentNumber { get; set; }
        public DateTime DateTime { get; set; }
        public string UserId { get; set; }
        public string PdtNumber { get; set; }
        public string ClientUniqueId { get; set; }
        public string Type { get; set; }
        public string Message { get; set; }
    }
}
