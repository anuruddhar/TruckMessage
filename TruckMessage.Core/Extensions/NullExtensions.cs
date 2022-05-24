using System;
using System.Collections.Generic;
using System.Text;

namespace TruckMessage.Core.Extensions {
    public static class NullExtensions {

        public static object ToNullDateTime(this DateTime value) {
            if (value == DateTime.MinValue) {
                return DBNull.Value;
            } else {
                return value;
            }
        }

        public static object ToNullInterger(this Int32 value) {
            if (value == int.MinValue || value == -1) {
                return DBNull.Value;
            } else {
                return value;
            }
        }

        public static object ToNullString(this String value) {
            if (string.IsNullOrEmpty(value) || value == "" || value == String.Empty || value == null || value == "-1" || value == "null") {
                return DBNull.Value;
            } else {
                return value;
            }
        }



        public static object ToNullBinary(this byte[] value) {
            if (value == null) {
                return DBNull.Value;
            } else {
                return value;
            }
        }

    }
}
