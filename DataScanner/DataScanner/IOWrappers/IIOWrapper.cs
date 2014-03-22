namespace DataScanner.IOWrappers {
    public interface IIOWrapper {
        IFileWrapper FileWrapper { get; }
        IDirectoryWrapper DirectoryWrapper { get; }
    }
}
