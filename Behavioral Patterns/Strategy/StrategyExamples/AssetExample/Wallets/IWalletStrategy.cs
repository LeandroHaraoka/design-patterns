using AssetExamples.Assets;
using AssetExamples.Assets.Movements;

namespace AssetExample.Wallets
{
    public interface IWalletStrategy<TMovement> where TMovement : Movement
    {
        void AddAsset(Asset<TMovement> asset);
    }
}
