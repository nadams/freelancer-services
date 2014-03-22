using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataScanner.Common;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using System.Linq;

namespace DataScanner.Tests.Common {

    [TestClass, ExcludeFromCodeCoverage]
    public class SomeTests {

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void Some_ValueIsNull_ExceptionThrown() {
            new Some<object>(null);
        }

        [TestMethod]
        public void HasValue_SomeHasValue_ReturnsTrue() {
            var some = new Some<object>(new object());

            Assert.IsTrue(some.HasValue);
        }

        [TestMethod]
        public void GetEnumerator_SomeHasValue_EnumeratorHasOneElement() {
            var some = new Some<object>(new object());

            Assert.AreEqual(1, some.Count());
        }

        [TestMethod]
        public void Value_SomeHasValue_ValueReturned() {
            var value = "this is a value";

            var some = new Some<string>(value);

            Assert.AreEqual(value, some.Value);
        }

        [TestMethod]
        public void Equals_SomeObjectsAreEqual_ReturnsTrue() {
            var value = "this is a value";

            var some1 = new Some<string>(value);
            var some2 = new Some<string>(value);

            Assert.IsTrue(some1.Equals(some2));
        }

        [TestMethod]
        public void Equals_ObjectsNotSameType_ReturnsFalse() {
            var value = "this is a value";

            var some1 = new Some<string>(value);
            var some2 = new Some<object>(value);

            Assert.IsFalse(some1.Equals(some2));
        }

        [TestMethod]
        public void Equals_ValuesDifferentValue_ReturnsFalse() {
            var some1 = new Some<string>("value 1");
            var some2 = new Some<string>("value 2");

            Assert.IsFalse(some1.Equals(some2));
        }

        [TestMethod]
        public void GetHashCode_ReturnsValueHashCode() {
            var value = "some string";
            var some = new Some<string>(value);

            Assert.AreEqual(value.GetHashCode(), some.GetHashCode());
        }
    }
}
