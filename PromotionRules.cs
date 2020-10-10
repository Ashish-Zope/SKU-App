using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SKU_App
{
    public class PromotionRules
    {
        public void Promotion_1(List<Cart> cart)
        {
            //get the cart values if id is 1 .
            var cart1 = cart.FirstOrDefault(w => w.Id == 1);
            int promotionPrice = 130;
            int promotionCount = 3;
            if (cart1 != null)
            {
                if (cart1.itemCount >= promotionCount)
                {
                    //  int count= cart.Count(c => c.Id == 3);
                    int promotions = cart1.itemCount / promotionCount;
                    cart1.TotalPrice = (promotions * promotionPrice) + ((cart1.itemCount - (promotions * promotionCount)) * cart1.price);
                }
            }
        }
        public void Promotion_2(List<Cart> cart)
        {

            //get the cart values if id is 2 .
            var cart1 = cart.FirstOrDefault(w => w.Id == 2);
            int promotionPrice = 45;
            int promotionCount = 2;
            if (cart1 != null)
            {
                if (cart1.itemCount >= promotionCount)
                {
                    int promotions = cart1.itemCount / promotionCount;
                    cart1.TotalPrice = (promotions * promotionPrice) + ((cart1.itemCount - (promotions * promotionCount)) * cart1.price);
                }
            }
        }
        public void Promotion_3(List<Cart> cart)
        {
            int itemCId = 3;
            int itemDId = 4;
            int promotionValue = 30;
            var itemC = cart.FirstOrDefault(s => s.Id == itemCId);
            var itemD = cart.FirstOrDefault(s => s.Id == itemDId);
            if (itemC != null && itemD != null)
            {
                int minCount = Math.Min(itemC.itemCount, itemD.itemCount);
                //calculate the price for item c
                int itemCTotal = (itemC.itemCount - minCount) * itemC.price;
                //calculate the price for item D +promotion.
                int itemDTotal = ((itemD.itemCount - minCount) * itemD.price) + (minCount * promotionValue);
                //add the total in cart.
                itemC.TotalPrice = itemCTotal;
                itemD.TotalPrice = itemDTotal;
            }
        }
    }
}
