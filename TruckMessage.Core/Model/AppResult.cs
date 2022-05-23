using System;
using System.Collections.Generic;
using System.Text;

namespace TruckMessage.Core.Model {
    public class AppResult {
        public AppResult() : this(true) { }
        public AppResult(bool val) : this(val, null) { }

        public AppResult(bool val, Exception exception) {
            this.Success = val;
            this.ResultID = string.Empty;
        }

        public bool Success { get; set; }
        public string ResultID { get; set; }
        public object Result { get; set; }
        public string UserMessage { get; set; }
        public Dictionary<string, List<KeyValuePair<string, int>>> ResultValue { get; set; } = new Dictionary<string, List<KeyValuePair<string, int>>>();

    }
}
