//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.261
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InfusionSoft
{
    using Definition;
    
    
    internal partial class ProductServiceWrapper : ServiceBase<IProductServiceDefinition>, IProductService
    {

        public ProductServiceWrapper(InfusionSoft.IInfusionSoftConfiguration configuration, IMethodListenerProvider listenerProvider) :
            base(configuration, listenerProvider)
        {
        }
        
        public virtual object GetInventory(int productId)
        {
            return Invoke(d => d.GetInventory(ApiKey, productId));
        }
        
        public virtual object IncrementInventory(int productId)
        {
            return Invoke(d => d.IncrementInventory(ApiKey, productId));
        }
        
        public virtual object DecrementInventory(int productId)
        {
            return Invoke(d => d.DecrementInventory(ApiKey, productId));
        }
        
        public virtual object IncreaseInventory(int productId, int quantity)
        {
            return Invoke(d => d.IncreaseInventory(ApiKey, productId, quantity));
        }
        
        public virtual object DecreaseInventory(int productId, int quantity)
        {
            return Invoke(d => d.DecreaseInventory(ApiKey, productId, quantity));
        }
        
        public virtual object DeactivateCreditCard(int creditCardId)
        {
            return Invoke(d => d.DeactivateCreditCard(ApiKey, creditCardId));
        }
    }
}
