using System;
using System.Collections.Generic;
using System.Text;

namespace SKU_App
{
   public interface ICartRepository
    {
        void addSku(int skuId);
        List<Cart> getList();
        int getOrderTotal();
    }
}
