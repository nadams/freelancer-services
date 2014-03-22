using System.Diagnostics.CodeAnalysis;
using DataScanner.ResourceLoader;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataScanner.Tests.ResourceLoader {

    [TestClass, ExcludeFromCodeCoverage]
    public class FreelancerIdConverterTests {

        [TestMethod]
        public void Convert_ValueOfZero_ReturnsZero() {
            var converter = new FreelancerIdConverter();

            var result = converter.Convert(0);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Convert_ValueOf260910_Returns64302() {
            var converter = new FreelancerIdConverter();

            var result = converter.Convert(260910);

            Assert.AreEqual(64302, result);
        }

        [TestMethod]
        public void Convert_ValueLessThan16_ReturnsValue() {
            var converter = new FreelancerIdConverter();

            var result = converter.Convert(13);

            Assert.AreEqual(13, result);
        }
    }
}
