using System;
using System.Collections.Generic;
using System.IO;

namespace DataScanner.Scanners {
    public class INIScanner {
        public List<Tuple<string, IDictionary<string, string>>> ScanINI(StreamReader stream) {
            var result = new List<Tuple<string, IDictionary<string, string>>>();

            string line;
            while((line = stream.ReadLine()) != null) {
                if(line.StartsWith("[") && line.EndsWith("]")) {
                    var values = new Dictionary<string, string>();
                    var section = new Tuple<string, IDictionary<string, string>>(line, values);

                    while((line = stream.ReadLine()) != string.Empty) {
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
    }
}
