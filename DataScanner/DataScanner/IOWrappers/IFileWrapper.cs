using System.IO;

namespace DataScanner.IOWrappers {
    public interface IFileWrapper {
        StreamReader OpenText(string path);
        bool Exists(string path);
    }
}
