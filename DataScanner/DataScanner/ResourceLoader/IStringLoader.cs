using System;

namespace DataScanner.ResourceLoader {
    public interface IStringLoader : IDisposable {
        string Load(int id);
    }
}
