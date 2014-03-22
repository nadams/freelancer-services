using System;

namespace DataScanner.Common {
    public static class OptionExtensions {
        public static T GetOrElse<T>(this IOption<T> option, Func<T> defaultExpression) {
            if(option.HasValue) {
                return option.Value;
            }

            return defaultExpression();
        }
    }
}
