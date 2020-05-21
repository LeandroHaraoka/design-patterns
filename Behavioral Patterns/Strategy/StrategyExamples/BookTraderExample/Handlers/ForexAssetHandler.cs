using AssetExample.Assets.Movements;
using BookTraderExample.Assets;
using BookTraderExample.Assets.Mappers;
using System;

namespace BookTraderExample.Handlers
{
    public class ForexAssetHandler : AssetHandler
    {
        public override AssetRequest Handle(AssetRequest request)
        {
            if (request.AssetType == AssetTypes.Forex)
            {
                Console.WriteLine("Create Forex Asset");

                var asset = MapAssetFromRequest.Execute<ForexMovement>(request);

                asset.AddAssetToWallet();
            }

            return base.Handle(request);
        }
    }
}
