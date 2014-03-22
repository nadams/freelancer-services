using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using DataScanner.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace DataScanner.Tests.Common {

    [TestClass, ExcludeFromCodeCoverage]
    public class NoneTests {

        [TestMethod]
        public void HasValue_ReturnsFalse() {
            var none = new None<object>();

            Assert.IsFalse(none.HasValue);
        }

        [TestMethod, ExpectedException(typeof(NoneHasNoValueException))]
        public void Value_ThrowsException() {
            var none = new None<object>();

            var value = none.Value;
        }

        [TestMethod]
        public void GetEnumerator_CountIsZero() {
            var none = new None<object>();

            Assert.AreEqual(0, none.Count());
        }

        [TestMethod]
        public void Equals_TypesAreSame_ReturnsTrue() {
            var none1 = new None<string>();
            var none2 = new None<string>();

            Assert.IsTrue(none1.Equals(none2));
        }

        [TestMethod]
        public void Equals_TypesAreNotSame_ReturnsFalse() {
            var none1 = new None<string>();
            var none2 = new None<object>();

            Assert.IsFalse(none1.Equals(none2));
        }

        [TestMethod]
        public void IEquatableEquals_ReturnsFalse() {
            var none = new None<object>();

            Assert.IsFalse(((IEquatable<object>)none).Equals(new object()));
        }

        [TestMethod]
        public void GetHashCode_ReturnsNegativeOne() {
            var none = new None<object>();

            Assert.AreEqual(-1, none.GetHashCode());
        }
    }
}
