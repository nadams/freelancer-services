using System.Diagnostics.CodeAnalysis;
using System.IO;

namespace DataScanner.IOWrappers {

    [ExcludeFromCodeCoverage]
    public class FileWrapper : IFileWrapper {
        public StreamReader OpenText(string path) {
            return File.OpenText(path);
        }

        public bool Exists(string path) {
            return File.Exists(path);
        }
    }
}
