using System;
using System.Collections.Generic;
using System.Text;

namespace TruckMessage.Core.Attributes {
    public sealed class JavascriptEnumAttribute : Attribute {
        public string[] Groups { get; set; }

        public JavascriptEnumAttribute(params string[] groups) {
            Groups = groups;
        }
    }
}
