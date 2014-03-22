using System.IO;

namespace DataScanner.IOWrappers {
    public interface IFileWrapper {
        FileStream OpenRead(string path);
        bool Exists(string path);
    }
}
