using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SKU_App
{
   public class CartRepository
    {
       private List<Sku> cart;
        CartRepository()
        {
            cart = new List<Sku>();
        }
        public void addSku(int skuId)
        {
            SkuRepository skuRepository = new SkuRepository();
            this.cart.Add(skuRepository.GetSkuById(skuId));
        }
        public List<Sku> getList()
        {
            return cart;
        }
        public int getTotal()
        {
            return cart.Sum(s => s.price);
        }
    }
}
