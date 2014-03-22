using System;
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

        bool IEquatable<T>.Equals(T other) {
            return other.Equals(this.Value);
        }

        public override bool Equals(object obj) {
            bool result = true;

            if(obj is Some<T>) {
                var otherValue = ((Some<T>)obj).Value;

                result = ((IEquatable<T>)this).Equals(otherValue);
            } else {
                result = false;
            }

            return result;
        }

        public override int GetHashCode() {
            return this.Value.GetHashCode();
        }
    }
}
