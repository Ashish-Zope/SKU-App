using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SKU_App
{
   public class CartRepository
    {
       private List<Cart> cart;
     public   CartRepository()
        {
            cart = new List<Cart>();
        }
        public void addSku(int skuId)
        {
            SkuRepository skuRepository = new SkuRepository();
            var sku = skuRepository.GetSkuById(skuId);
            if (sku != null)
            {
                var cartItem = cart.FirstOrDefault(c => c.Id == skuId);
                if (cartItem != null)
                {
                    cartItem.itemCount = cartItem.itemCount + 1;
                    cartItem.TotalPrice = cartItem.TotalPrice + sku.price;

                }
                else
                    this.cart.Add(new Cart {Id=sku.Id,SkuName=sku.SkuName,price=sku.price,itemCount=1,TotalPrice=sku.price });
            }
        }
        public List<Cart> getList()
        {
            return cart;
        }
        public int getOrderTotal()
        {
            return cart.Sum(s => s.TotalPrice);
        }
    }
}
