namespace DataScanner.Scanners {
    public interface IScanner {
        string BaseDirectory { get; }

        string Scan();
    }
}
