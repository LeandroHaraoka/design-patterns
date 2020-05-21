using AssetExample.Assets.Movements;
using BookTraderExample.Assets;
using BookTraderExample.Assets.Mappers;
using System;

namespace BookTraderExample.Handlers
{
    public class BondAssetHandler : AssetHandler
    {
        public override AssetRequest Handle(AssetRequest request)
        {
            if (request.AssetType == AssetTypes.Bond)
            {
                Console.WriteLine("Create Bond Asset");

                var asset = MapAssetFromRequest.Execute<BondMovement>(request);

                asset.AddAssetToWallet();
            }

            return base.Handle(request);
        } 
    }
}
