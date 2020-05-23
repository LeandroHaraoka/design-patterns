using System;
using System.IO;

namespace BankReportsExample.Services.ReportReader.Extensions
{
    public static class FilePath
    {
        public static string ForexForwardContratcs() => Path.Combine(ForexPath(), "ForexForwardContratcs.xlsx");

        public static string ForexVanillaOptions() => Path.Combine(ForexPath(), "ForexVanillasOptions.xlsx");

        private static string ForexPath()
        {
            var currentDirectiory = Environment.CurrentDirectory;
            return Path.Combine(currentDirectiory, "Spreadsheets");
        }
    }
}
