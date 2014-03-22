using System.Diagnostics.CodeAnalysis;
using DataScanner.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace DataScanner.Tests.Common {

    [TestClass, ExcludeFromCodeCoverage]
    public class OptionExtensionsTests {

        [TestMethod]
        public void GetOrElse_OptionIsSome_ValueReturned() {
            var option = new Some<string>("some value");

            var result = option.GetOrElse(() => "default value");

            Assert.AreEqual("some value", result);
        }

        [TestMethod]
        public void GetOrElse_OptionIsNone_DefaultValueReturned() {
            var option = new None<string>();

            var result = option.GetOrElse(() => "default value");

            Assert.AreEqual("default value", result);
        }
    }
}
