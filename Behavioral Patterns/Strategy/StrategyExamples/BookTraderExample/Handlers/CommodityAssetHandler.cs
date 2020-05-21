using AssetExample.Assets.Movements;
using BookTraderExample.Assets;
using BookTraderExample.Assets.Mappers;
using System;

namespace BookTraderExample.Handlers
{
    public class CommodityAssetHandler : AssetHandler
    {
        public override AssetRequest Handle(AssetRequest request)
        {
            if (request.AssetType == AssetTypes.Commodity)
            {
                Console.WriteLine("Create Commodity Asset");

                var asset = MapAssetFromRequest.Execute<CommodityMovement>(request);

                asset.AddAssetToWallet();
            }

            return base.Handle(request);
        }
    }
}
