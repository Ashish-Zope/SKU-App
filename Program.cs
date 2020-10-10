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
                initilize();
                 
        }

        static void initilize()
        {
            SkuRepository skuRepository = new SkuRepository();
            PromotionRepository promotionRepository = new PromotionRepository();
            CartRepository cartRepository = new CartRepository();
            while (true)
            {   
                Console.WriteLine("welcome to e Promotion Engine.......\n");
                Console.WriteLine("SKU List.");
                //print the SKU list
                var skuList = skuRepository.getSkuList();
                Console.WriteLine("SKU          Price()");
                foreach (var item in skuList)
                {
                    Console.WriteLine("{0}              {1}", item.SkuName, item.price);
                }
                //print the promotion list
                var promotions = promotionRepository.getPromotionList();
                Console.WriteLine("\nPromotions.");
                foreach (var item in promotions)
                {
                    Console.WriteLine("{0}", item.PromotionName);
                }
                //print the promotion list
                var cart = cartRepository.getList();
                Console.WriteLine("\nCart.");
                Console.WriteLine("SKU Name\t\tPrice\t\tTotal");
                foreach (var item in cart)
                {
                    Console.WriteLine("{0}\t\t\t{1}*{3}\t\t{2}\n", item.SkuName, item.price,item.TotalPrice,item.itemCount);
                }
                Console.WriteLine("Total.\t\t\t\t\t{0}", cartRepository.getOrderTotal());
                Console.WriteLine("Please enter SKU id to add item in cart.");
                int skuId = int.Parse(Console.ReadLine());
                cartRepository.addSku(skuId);
                //get the order list from cart and apply promotion.
                promotionRepository.applyPromotionPrice(cartRepository.getList());

                Console.Clear();
            }
        }
    }
}
