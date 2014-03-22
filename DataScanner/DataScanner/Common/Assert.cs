using System;

namespace DataScanner.Common {
    public static class Assert {
        public static void IsNotNull(object o, string parameterName) {
            if(o == null) {
                throw new ArgumentException(parameterName);
            }
        }
    }
}
