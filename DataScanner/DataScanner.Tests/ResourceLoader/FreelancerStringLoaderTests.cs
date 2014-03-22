using System;
using System.Diagnostics.CodeAnalysis;
using DataScanner.Common;
using DataScanner.ResourceLoader;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace DataScanner.Tests.ResourceLoader {

    [TestClass, ExcludeFromCodeCoverage]
    public class FreelancerStringLoaderTests {

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void FreelancerStringLoader_StringLoaderIsNull_ExceptionThrown() {
            new FreelancerStringLoader(null, new FreelancerIdConverter());
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void FreelancerStringLoader_ConverterIsNull_ExceptionThrown() {
            new FreelancerStringLoader(this.GetEmptyStringLoader(), null);
        }

        [TestMethod]
        public void GetString_IdOfZero_ReturnsNone() {
            var stringLoader = new FreelancerStringLoader(this.GetEmptyStringLoader(), new FreelancerIdConverter());

            var result = stringLoader.GetString(0);

            Assert.IsInstanceOfType(result, typeof(None<string>));
        }

        [TestMethod]
        public void GetString_IdGreaterThanZero_NonEmptyStringReturned() {
            var stringLoader = new Mock<IStringLoader>();
            stringLoader.Setup(x => x.Load(It.IsAny<int>())).Returns(string.Empty);

            var freelancerStringLoader = new FreelancerStringLoader(stringLoader.Object, new FreelancerIdConverter());

            var result = freelancerStringLoader.GetString(1);

            Assert.IsInstanceOfType(result, typeof(Some<string>));
        }

        private IStringLoader GetEmptyStringLoader() {
            var mock = new Mock<IStringLoader>();

            return mock.Object;
        }
    }
}
