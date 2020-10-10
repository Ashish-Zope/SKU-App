using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SKU_App
{
  public  class PromotionRepository
    {
       private List<Promotion> promotionList;
        public PromotionRepository()
        {
            promotionList = new List<Promotion>();
            bindPromotionList();
        }

        private void bindPromotionList()
        {
            this.promotionList = new List<Promotion> {   
            new Promotion{PromotionId=1,PromotionName="3 of A's for 130"},
            new Promotion{PromotionId=2,PromotionName="2 of B's for 45"},
            new Promotion{PromotionId=3,PromotionName="C & D for 30"},
            };
        }
        public List<Promotion> getPromotionList()
        {
            return promotionList;
        }
        public Promotion getPromotionById(int id)
        {
            return promotionList.FirstOrDefault(f => f.PromotionId == id);
        }

        public void applyPromotionPrice(List<Cart> cart)
        {

        }



    }
}
