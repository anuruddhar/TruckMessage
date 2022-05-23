using System;
using System.Collections.Generic;
using System.Text;
using TruckMessage.Core.Cqrs;

namespace TruckMessage.Public.Queries {
    public class TruckMessageQuery : IQuery {
        public int CosignmentNumber { get; set; }
        public string UserId { get; set; }
        public string PdtNumber { get; set; }
    }
}
