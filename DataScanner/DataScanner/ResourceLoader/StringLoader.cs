using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Text;

namespace DataScanner.ResourceLoader {
    public class StringLoader : IStringLoader {
        [DllImport("kernel32", CharSet = CharSet.Auto)]
        static extern IntPtr LoadLibrary(string filename);

        [DllImport("kernel32", CharSet = CharSet.Auto)]
        static extern bool FreeLibrary(IntPtr lib);

        [DllImport("user32", CharSet = CharSet.Auto)]
        static extern int LoadString(IntPtr hInstance, int uID, StringBuilder stringBuilder, int BufferMax);

        IntPtr libPtr;

        public StringLoader(string filename) {
            libPtr = LoadLibrary(filename);

            if(libPtr == IntPtr.Zero) {
                throw new Win32Exception();
            }
        }

        public string Load(int id) {
            var value = string.Empty;
            var sb = new StringBuilder(512);

            int length = LoadString(libPtr, id, sb, sb.Capacity + 1);

            if(length > 0) {
                value = sb.ToString();
            }

            return value;
        }

        public void Dispose() {
            FreeLibrary(libPtr);
            GC.SuppressFinalize(this);
        }

        ~StringLoader() {
            Dispose();
        }
    }
}
