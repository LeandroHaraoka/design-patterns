using ExcelDataReader;
using static BankReportsExample.Spreadsheets.ForexForwardContractsLayout;

namespace BankReportsExample.Services.ReportReader.Extensions
{
    public static class ExcelDataReaderExtensions
    {
        public static void MoveToForexHeader(this IExcelDataReader reader)
        {
            while (reader.Read())
            {
                if (reader.GetValue(0)?.ToString() != nameof(TradeId))
                    continue;

                break;
            }
        }
    }
}
