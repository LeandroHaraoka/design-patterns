using BankReportsExample.Forex;
using ExcelDataReader;
using System;
using static BankReportsExample.Spreadsheets.ForexForwardContractsLayout;

namespace BankReportsExample.Services.ReportReader.Extensions
{
    public static class FxForwardContractMapper
    {
        public static FxOperation MapForwardContract(this IExcelDataReader reader)
        {
            return new FxForwardContract(
                                reader.GetDateTime(TradeDate),
                                Enum.Parse<CurrencyPair>(reader.GetValue(Symbol).ToString()),
                                reader.GetDouble(Notional),
                                reader.GetDouble(Price),
                                Enum.Parse<Direction>(reader.GetValue(BuyOrSell).ToString()),
                                reader.GetDateTime(WithdrawDate),
                                reader.GetDateTime(SettlementDate));
        }
    }
}
