using CommandDotNet;
using System;
using System.Collections.Generic;
using System.Linq;

namespace City.Chain.CLI
{
    internal class Program
    {
        private static int Main(string[] args)
        {
            AppRunner<CommandLine> appRunner = new AppRunner<CommandLine>();
            return appRunner.Run(args);
        }
    }
}
