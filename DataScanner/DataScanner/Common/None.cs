using System;
using System.Collections;
using System.Collections.Generic;

namespace DataScanner.Common { 
    public sealed class None<T> : IOption<T> {
        private readonly List<T> option;

        public bool HasValue {
            get { return false; }
        }

        public T Value {
            get { throw new NoneHasNoValueException(); }
        }

        public None() {
            this.option = new List<T>();
        }

        public IEnumerator<T> GetEnumerator() {
            return this.option.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return this.option.GetEnumerator();
        }

        public bool Equals(T other) {
            return false;
        }

        public override bool Equals(object obj) {
            return obj is None<T>;
        }

        public override int GetHashCode() {
            return -1;
        }
    }
}
