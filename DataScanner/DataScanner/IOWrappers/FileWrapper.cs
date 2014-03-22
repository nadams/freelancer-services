using System.Diagnostics.CodeAnalysis;
using System.IO;

namespace DataScanner.IOWrappers {

    [ExcludeFromCodeCoverage]
    public class FileWrapper : IFileWrapper {
        public FileStream OpenRead(string path) {
            return File.OpenRead(path);
        }

        public bool Exists(string path) {
            return File.Exists(path);
        }
    }
}
