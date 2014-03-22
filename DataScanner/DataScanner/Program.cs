using CommandLine;
using DataScanner.Common;

namespace DataScanner {
    public class Program {
        public static void Main(string[] args) {
            var arguments = new Arguments();

            if(Parser.Default.ParseArguments(args, arguments)) {
                
            }
        }
    }
}
