using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SKU_App
{
   public class SkuRepository
    {
       private List<Sku> skuList;
       public SkuRepository()
        {
            this.skuList = new List<Sku>();
            bindSku();
        }
        private void bindSku()
        {
            this.skuList = new List<Sku>
            {
                new Sku{Id=1,SkuName="A",price=50},
                new Sku{Id=2,SkuName="B",price=30},
                new Sku{Id=3,SkuName="C",price=20},
                new Sku{Id=4,SkuName="D",price=15},
            };
        }
        public List<Sku> getSkuList()
        {
            return skuList;
        }
        public Sku GetSkuById(int id)
        {
            return skuList.FirstOrDefault(s => s.Id == id);
        }
    }
}
