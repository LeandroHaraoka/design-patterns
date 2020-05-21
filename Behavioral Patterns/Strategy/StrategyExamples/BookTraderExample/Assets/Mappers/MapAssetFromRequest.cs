using BookTraderExample.Assets.Movements;
using BookTraderExample.Extensions;
using System.Linq;

namespace BookTraderExample.Assets.Mappers
{
    public static class MapAssetFromRequest
    {
        public static Asset<TMovement> Execute<TMovement>(AssetRequest request) where TMovement : Movement
        {
            var asset = request.MapTo<Asset<TMovement>>();

            var movements = request.Movements.Select(m => m.MapTo<TMovement>());

            movements.ToList().ForEach(mov => asset.AddMovement(mov));

            return asset;
        }
    }
}
