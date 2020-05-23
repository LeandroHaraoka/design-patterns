using BankReportsExample.Forex;
using ExcelDataReader;
using System;
using static BankReportsExample.Spreadsheets.ForexVanillaOptionsLayout;

namespace BankReportsExample.Services.ReportReader.Extensions
{
    public static class FxVanillaOptionMapper
    {
        public static FxOperation MapVanillaOption(this IExcelDataReader reader)
        {
            return new FxVanillaOption(
                                reader.GetDateTime(TradeDate),
                                Enum.Parse<CurrencyPair>(reader.GetValue(Symbol).ToString()),
                                reader.GetDouble(Notional),
                                reader.GetDouble(Premium),
                                reader.GetDouble(Spot),
                                reader.GetDouble(Strike),
                                Enum.Parse<OptionType>(reader.GetValue(CallOrPut).ToString()),
                                Enum.Parse<ExecutionType>(reader.GetValue(AmericanOrEuropean).ToString()),
                                Enum.Parse<Direction>(reader.GetValue(BuyOrSell).ToString()),
                                reader.GetDateTime(WithdrawDate),
                                reader.GetDateTime(SettlementDate));
        }
    }
}
