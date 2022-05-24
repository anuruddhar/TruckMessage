using System;
using System.Collections.Generic;
using System.Text;

namespace TruckMessage.Core.Extensions {
    public static class StringExtensions {
        public static string ToCamelCase(this string s) {
            return s.Substring(0, 1).ToLower() + s.Substring(1);
        }

        public static string ToEmptyString(this string value) {
            if (string.IsNullOrEmpty(value)) {
                value = string.Empty;
                return value;
            }
            return value;
        }

    }
}
