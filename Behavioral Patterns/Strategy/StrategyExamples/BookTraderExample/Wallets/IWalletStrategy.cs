using BookTraderExample.Assets;
using BookTraderExample.Assets.Movements;

namespace AssetExample.Wallets
{
    public interface IWalletStrategy<TMovement> where TMovement : Movement
    {
        void AddAsset(Asset<TMovement> asset);
    }
}
