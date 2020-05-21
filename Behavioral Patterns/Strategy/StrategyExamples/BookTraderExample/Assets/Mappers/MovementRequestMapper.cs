using AssetExample.Assets.Movements;
using AutoMapper;

namespace BookTraderExample.Assets.Mappers
{
    public sealed class MovementRequestMapper : Profile
    {
        public MovementRequestMapper()
        {
            CreateMap<MovementRequest, CashMovement>()
                .ConvertUsing(s => new CashMovement(s.WithdrawDate, s.Price, s.Direction, s.Volume));
            
            CreateMap<MovementRequest, BondMovement>()
                .ConvertUsing(s => new BondMovement(s.WithdrawDate, s.Price, s.Direction, s.Index, s.Rate, s.Volume));
            
            CreateMap<MovementRequest, ForexMovement>()
                .ConvertUsing(s => new ForexMovement(s.WithdrawDate, s.Price, s.ReferenceCurrency, s.Currency, s.Volume));
            
            CreateMap<MovementRequest, CommodityMovement>()
                .ConvertUsing(s => new CommodityMovement(s.WithdrawDate, s.Price, s.CommodityIdentifier, s.Volume));
            
            CreateMap<MovementRequest, StockMovement>()
                .ConvertUsing(s => new StockMovement(s.WithdrawDate, s.Price, s.StockCode, s.Volume));

        }
    }
}
