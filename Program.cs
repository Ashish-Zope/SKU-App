using System;
using System.Collections.Generic;

namespace SKU_App
{
    class Program
    {
        public List<Sku> SkuList { get; }
        public List<Promotion> PromotionList{ get; set; }
        static void Main(string[] args)
        {

            PromotionRepository p = new PromotionRepository();
            var pl=p.getPromotionList();
            Console.WriteLine("Sku App Start");
        }

        public void initilize()
        {


        }

        

    }
}
