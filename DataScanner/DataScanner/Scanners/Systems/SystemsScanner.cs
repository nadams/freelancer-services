using System.IO;
using DataScanner.Common;
using DataScanner.IOWrappers;
using Newtonsoft.Json.Linq;

namespace DataScanner.Scanners.Systems {
    public class SystemsScanner : IScanner {
        private readonly string baseDirectory;
        private readonly IIOWrapper ioWrapper;

        public string BaseDirectory {
            get { return this.baseDirectory; }
        }

        public SystemsScanner(string baseDirectory, IIOWrapper ioWrapper) {
            Assert.IsNotNull(baseDirectory, "baseDirectory");
            Assert.IsNotNull(ioWrapper, "ioWrapper");

            this.baseDirectory = baseDirectory;
            this.ioWrapper = ioWrapper;
        }

        public string Scan() {
            var path = Path.Combine(this.baseDirectory, "DATA", "UNIVERSE", "universe.ini").ToString();

            using(var universe = this.ioWrapper.FileWrapper.OpenText(path)) {
                

                string line;
                while((line = universe.ReadLine()) != null) {
                    if(line.ToLower() == "[system]") {
                    
                    }
                }

            }

            return string.Empty;
        }
    }
}
