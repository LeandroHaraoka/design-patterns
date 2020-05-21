using BookTraderExample.Assets;
using BookTraderExample.Assets.Movements;

namespace BookTraderExample.Handlers
{
    public abstract class AssetHandler : IHandler<AssetRequest>
    {
        private IHandler<AssetRequest> _next;

        public virtual AssetRequest Handle(AssetRequest request)
        {
            if (_next != null)
                return _next.Handle(request);

            return default;
        }

        public IHandler<AssetRequest> SetNext(IHandler<AssetRequest> handler)
        {
            _next = handler;
            return _next;
        }
    }
}
