using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CommonAssert = DataScanner.Common.Assert;

namespace DataScanner.Tests.Common {

    [TestClass, ExcludeFromCodeCoverage]
    public class AssertTests {

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void IsNotNull_ArgumentIsNull_ExceptionIsThrown() {
            object o = null;


            CommonAssert.IsNotNull(o, "o");
        }
    }
}
