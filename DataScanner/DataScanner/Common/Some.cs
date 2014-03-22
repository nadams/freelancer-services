using System.Collections;
using System.Collections.Generic;

namespace DataScanner.Common {
    public sealed class Some<T> : IOption<T> {
        private readonly List<T> option;
 
        public bool HasValue {
            get { return true; }
        }

        public T Value {
            get { return this.option[0]; }
        }

        public Some(T value) {
            Assert.IsNotNull(value, "value");

            this.option = new List<T> { value };
        }

        public IEnumerator<T> GetEnumerator() {
            return this.option.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return this.option.GetEnumerator();
        }
    }
}
