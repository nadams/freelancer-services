using System;
using CommandLine;
using DataScanner.Parameters;
using DataScanner.ResourceLoader;

namespace DataScanner {
    public class Program {
        public static void Main(string[] args) {
            var options = new Options();

            if(Parser.Default.ParseArguments(args, options)) {
                using(var stringLoader = new FreelancerStringLoader(new StringLoader("NameResources.dll"), new FreelancerIdConverter())) {
                    Console.WriteLine(stringLoader.GetString(options.ResourceId));
                }
            }
        }
    }
}
