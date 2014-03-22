using CommandLine;
using DataScanner.Parameters;

namespace DataScanner {
    public class Program {
        public static void Main(string[] args) {
            var options = new Options();

            if(Parser.Default.ParseArguments(args, options)) {
                
            }
        }
    }
}
