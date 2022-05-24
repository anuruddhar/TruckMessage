using System;
using System.Collections.Generic;
using System.Text;

namespace TruckMessage.Core.Attributes {
    public class QueryStringAttribute : Attribute {
        public string Name { get; set; } = string.Empty;

        public QueryStringAttribute(string _name) {
            this.Name = _name;
        }

    }
}
