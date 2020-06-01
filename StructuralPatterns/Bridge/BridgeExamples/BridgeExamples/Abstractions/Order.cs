using BridgeExamples.Implementations;

namespace BridgeExamples.Abstractions
{
    public abstract class Order
    {
        protected readonly Asset _asset;

        public Order(Asset asset) => _asset = asset;
        
        public abstract void Notify();
    }
}
