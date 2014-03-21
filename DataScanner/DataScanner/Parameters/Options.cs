using CommandLine;
using CommandLine.Text;

namespace DataScanner.Parameters {
    public class Options {
        [Option('d', "directory", Required = true, HelpText = "Base directory of the freelancer install.")]
        public string FreelancerDirectory { get; set; }

        [HelpOption]
        public string GetUsage() {
            return HelpText.AutoBuild(this);
        }
    }
}
