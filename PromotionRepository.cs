using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SKU_App
{
    delegate void PromotionRulesDel(List<Cart> cart);
    public class PromotionRepository: IPromotionRepository
    {
        private List<Promotion> promotionList;
        private PromotionRules rules;

        public PromotionRepository()
        {
            promotionList = new List<Promotion>();
            rules = new PromotionRules();
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
            calculatePrice(cart, rules.Promotion_1);
            calculatePrice(cart, rules.Promotion_2);
            calculatePrice(cart, rules.Promotion_3);
        }
        //apply promotion 
        private void calculatePrice(List<Cart> cart, PromotionRulesDel promotion)
        {
            promotion(cart);
        }
    }
}
