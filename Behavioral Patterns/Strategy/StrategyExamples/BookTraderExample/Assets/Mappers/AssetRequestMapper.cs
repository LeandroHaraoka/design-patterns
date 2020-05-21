using AssetExample.Assets.Movements;
using AssetExample.Wallets;
using AutoMapper;

namespace BookTraderExample.Assets.Mappers
{
    public sealed class AssetRequestMapper : Profile
    {
        public AssetRequestMapper()
        {
            CreateMap<AssetRequest, Asset<CashMovement>>()
                .ConvertUsing(s => new Asset<CashMovement>(s.Buyer, s.Seller, s.TradeDate, new CashWalletStrategy()));

            CreateMap<AssetRequest, Asset<BondMovement>>()
                .ConvertUsing(s => new Asset<BondMovement>(s.Buyer, s.Seller, s.TradeDate, new BondWalletStrategy()));

            CreateMap<AssetRequest, Asset<ForexMovement>>()
                .ConvertUsing(s => new Asset<ForexMovement>(s.Buyer, s.Seller, s.TradeDate, new ForexWalletStrategy()));

            CreateMap<AssetRequest, Asset<StockMovement>>()
                .ConvertUsing(s => new Asset<StockMovement>(s.Buyer, s.Seller, s.TradeDate, new StockWalletStrategy()));

            CreateMap<AssetRequest, Asset<CommodityMovement>>()
                .ConvertUsing(s => new Asset<CommodityMovement>(s.Buyer, s.Seller, s.TradeDate, new CommodityWalletStrategy()));
        }
    }
}
