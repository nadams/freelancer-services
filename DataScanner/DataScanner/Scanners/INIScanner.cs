using System;
using System.Collections.Generic;
using System.IO;
using DataScanner.Common;

namespace DataScanner.Scanners {
    public class INIScanner : IDisposable {
        private readonly StreamReader reader;

        public INIScanner(StreamReader reader) {
            Assert.IsNotNull(reader, "reader");

            this.reader = reader;
        }

        public List<Tuple<string, IDictionary<string, string>>> ScanINI() {
            var result = new List<Tuple<string, IDictionary<string, string>>>();

            string line;
            while((line = this.reader.ReadLine()) != null) {
                if(line.StartsWith("[") && line.EndsWith("]")) {
                    var values = new Dictionary<string, string>();
                    var section = new Tuple<string, IDictionary<string, string>>(line, values);

                    while((line = this.reader.ReadLine()) != string.Empty) {
                        var lineValue = line.Split(new char[] { '=' }, 2);

                        if(lineValue.Length == 2) {
                            values.Add(lineValue[0].Trim(), lineValue[1].Trim());
                        }
                    }

                    result.Add(section);
                }
            }

            return result;
        }

        public void Dispose() {
            this.reader.Dispose();
        }
    }
}
