using System.Diagnostics.CodeAnalysis;
using DataScanner.Common;

namespace DataScanner.IOWrappers {

    [ExcludeFromCodeCoverage]
    public class IOWrapper : IIOWrapper {
        private readonly IFileWrapper fileWrapper;
        private readonly IDirectoryWrapper directoryWrapper;

        public IFileWrapper FileWrapper {
            get { return this.fileWrapper; }
        }

        public IDirectoryWrapper DirectoryWrapper {
            get { return this.directoryWrapper; }
        }

        public IOWrapper(IFileWrapper fileWrapper, IDirectoryWrapper directoryWrapper) {
            Assert.IsNotNull(fileWrapper, "fileWrapper");
            Assert.IsNotNull(directoryWrapper, "directoryWrapper");
        }
    }
}
