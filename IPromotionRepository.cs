using System;
using System.Collections.Generic;
using System.Text;

namespace SKU_App
{
   public interface IPromotionRepository
    {
        List<Promotion> getPromotionList();
        Promotion getPromotionById(int id);
        void applyPromotionPrice(List<Cart> cart);
    }
}
