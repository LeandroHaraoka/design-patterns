using AssetExample.Assets.Movements;
using BookTraderExample.Assets;
using BookTraderExample.Assets.Mappers;
using BookTraderExample.Assets.Movements;
using System;

namespace BookTraderExample.Handlers
{
    public class CashAssetHandler : AssetHandler
    {
        public override AssetRequest Handle(AssetRequest request)
        {
            if (request.AssetType == AssetTypes.Cash)
            {
                Console.WriteLine("Create Cash Asset");

                var asset = MapAssetFromRequest.Execute<CashMovement>(request);

                asset.AddAssetToWallet();
            }

            return base.Handle(request);

        }
    }
}
