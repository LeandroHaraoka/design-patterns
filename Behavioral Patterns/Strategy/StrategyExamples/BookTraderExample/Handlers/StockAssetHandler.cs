using AssetExample.Assets.Movements;
using BookTraderExample.Assets;
using BookTraderExample.Assets.Mappers;
using System;

namespace BookTraderExample.Handlers
{
    public class StockAssetHandler : AssetHandler
    {
        public override AssetRequest Handle(AssetRequest request)
        {
            if (request.AssetType == AssetTypes.Stock)
            {
                Console.WriteLine("Create Stock Asset");

                var asset = MapAssetFromRequest.Execute<StockMovement>(request);

                asset.AddAssetToWallet();
            }

            return base.Handle(request);
        }
    }
}
