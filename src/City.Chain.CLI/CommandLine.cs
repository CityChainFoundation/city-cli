using CommandDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace City.Chain.CLI
{
    /// <summary>
    /// City Chain Command Line Utility.
    /// </summary>
    [ApplicationMetadata(Description = "City Chain: Command Line Utility", ExtendedHelpText = "Made with <3 by City Chain Developers")]
    public class CommandLine
    {
        [ApplicationMetadata(Description = "Generate a vanity address that starts with your personal prefix", Name = "vanity")]
        public void Vanity(string prefix, [Option]bool exact = false)
        {
            Console.WriteLine($"TBD:  {prefix}");
        }

        [ApplicationMetadata(Description = "Generate an address at random", Name = "address")]
        public void Address()
        {
            Console.WriteLine($"TBD");
        }
    }
}
