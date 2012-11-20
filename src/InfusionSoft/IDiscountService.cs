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
    using System;
    using System.Collections.Generic;
    
    
    public interface IDiscountService : InfusionSoft.IService
    {
        
        object AddFreeTrial(string name, string description, int freeTrialDays, int hidePrice, int subscriptionPlanId);
        
        object GetFreeTrial(int trialId);
        
        object AddOrderTotalDiscount(string name, string description, int applyDiscountToCommission, int percentOrAmt, int amt, string payType);
        
        object GetOrderTotalDiscount(int id);
        
        object AddCategoryDiscount(string name, string description, int applyDiscountToCommission, int amt);
        
        object GetCategoryDiscount(int id);
        
        object AddCategoryAssignmentToCategoryDiscount(int id, int productId);
        
        object GetCategoryAssignmentsForCategoryDiscount(int id);
        
        object AddProductTotalDiscount(string name, string description, int applyDiscountToCommission, int productId, int percentOrAmt, int amt);
        
        object GetProductTotalDiscount(string id);
        
        object AddShippingTotalDiscount(string name, string description, int applyDiscountToCommission, int percentOrAmt, int amt);
        
        object GetShippingTotalDiscount(int id);
    }
}