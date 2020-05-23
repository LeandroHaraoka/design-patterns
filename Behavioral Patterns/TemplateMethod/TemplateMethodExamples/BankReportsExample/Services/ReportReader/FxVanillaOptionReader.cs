using BankReportsExample.Forex;
using BankReportsExample.Services.ReportReader.Extensions;
using ExcelDataReader;
using System.Collections.Generic;
using System.IO;


namespace BankReportsExample.Services.ReportReader
{
    public class VanillaOptionReader
    {
        public List<FxOperation> ReadReport()
        {
            var filePath = FilePath.ForexVanillaOptions();

            var fxVanillaOptions = new List<FxOperation>();

            ReadFile();

            return fxVanillaOptions;

            void ReadFile()
            {
                using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = ExcelReaderFactory.CreateReader(stream))
                    {
                        reader.MoveToForexHeader();

                        while (reader.Read())
                        {
                            if (reader.GetValue(0) is null)
                                break;

                            fxVanillaOptions.Add(reader.MapVanillaOption());
                        }
                    }
                }
            }
        }

    }
}
