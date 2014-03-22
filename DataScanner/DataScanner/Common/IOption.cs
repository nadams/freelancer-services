using System.Collections.Generic;

namespace DataScanner.Common {
    public interface IOption<T> : IEnumerable<T> {
        bool HasValue { get; }
        T Value { get; }
    }
}
