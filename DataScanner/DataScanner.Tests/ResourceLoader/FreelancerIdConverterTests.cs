using DataScanner.ResourceLoader;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataScanner.Tests.ResourceLoader {

    [TestClass]
    public class FreelancerIdConverterTests {

        [TestMethod]
        public void Convert_ValueOfZero_ReturnsZero() {
            var converter = new FreelancerIdConverter();

            var result = converter.Convert(0);

            Assert.AreEqual(0, result);
        }
    }
}
