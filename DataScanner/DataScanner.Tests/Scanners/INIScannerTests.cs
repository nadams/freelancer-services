using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text;
using DataScanner.Scanners;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataScanner.Tests.Scanners {

    [TestClass, ExcludeFromCodeCoverage]
    public class INIScannerTests {

        [TestMethod]
        public void ScanINI_ContentIsEmpty_EmptyListReturned() {
            var scanner = new INIScanner();

            var result = scanner.ScanINI(this.GetStreamReader(""));

            Assert.IsFalse(result.Any());
        }

        [TestMethod]
        public void ScanINI_ContentJustHasSection_SectionWithNoValuesReturned() {
            var content = "[system]" + Environment.NewLine + Environment.NewLine;
            var scanner = new INIScanner();

            var result = scanner.ScanINI(this.GetStreamReader(content));

            Assert.AreEqual("[system]", result.First().Item1);
            Assert.IsFalse(result.First().Item2.Any());
        }

        [TestMethod]
        public void ScanINI_SectionHasValue_ValueAddedToCollection() {
            var content = 
@"[system]
test1 = 1
test2 = 2

";

            var scanner = new INIScanner();

            var result = scanner.ScanINI(this.GetStreamReader(content));

            Assert.AreEqual("1", result.First().Item2["test1"]);
            Assert.AreEqual("2", result.First().Item2["test2"]);
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void ScanINI_SectionHasDuplicateValue_ExceptionThrown() {
            var content =
@"[system]
test1 = 1
test1 = 2

";

            var scanner = new INIScanner();

            var result = scanner.ScanINI(this.GetStreamReader(content));
        }

        private StreamReader GetStreamReader(string content) {
            return new StreamReader(new MemoryStream(Encoding.UTF8.GetBytes(content)));
        }
    }
}
