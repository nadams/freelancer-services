using DataScanner.Common;

namespace DataScanner.Scanners.Systems {
    public class SystemsScanner : IScanner {
        private readonly string baseDirectory;
        public string BaseDirectory {
            get { return this.baseDirectory; }
        }

        public SystemsScanner(string baseDirectory) {
            Assert.IsNotNull(baseDirectory, "baseDirectory");

            this.baseDirectory = baseDirectory;
        }

        public string Scan() {
            throw new System.NotImplementedException();
        }
    }
}
