using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;

namespace DataScanner.IOWrappers {

    [ExcludeFromCodeCoverage]
    public class DirectoryWrapper : IDirectoryWrapper {
        public bool Exists(string path) {
            return Directory.Exists(path);
        }

        public IEnumerable<string> EnumerateDirectories(string path) {
            return Directory.EnumerateDirectories(path);
        }

        public IEnumerable<string> EnumerateDirectories(string path, string searchPattern) {
            return Directory.EnumerateDirectories(path, searchPattern);
        }

        public IEnumerable<string> EnumerateDirectories(string path, string searchPattern, SearchOption searchOption) {
            return Directory.EnumerateDirectories(path, searchPattern, searchOption);
        }

        public IEnumerable<string> EnumerateFiles(string path) {
            return Directory.EnumerateFiles(path);
        }

        public IEnumerable<string> EnumerateFiles(string path, string searchPattern) {
            return Directory.EnumerateFiles(path, searchPattern);
        }

        public IEnumerable<string> EnumerateFiles(string path, string searchPattern, SearchOption searchOption) {
            return Directory.EnumerateFiles(path, searchPattern, searchOption);
        }
    }
}
