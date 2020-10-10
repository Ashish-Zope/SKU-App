using System;
using System.Collections.Generic;

namespace SKU_App
{
    class Program
    {
        ISkuRepository skuRepository;
        IPromotionRepository promotionRepository;
        ICartRepository cartRepository; 
      public  Program()
        {
            skuRepository = new SkuRepository();
            promotionRepository = new PromotionRepository();
            cartRepository= new CartRepository();
        }
        static void Main(string[] args)
        {
            try
            {
                Program p = new Program();
                p.initilize();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        void initilize()
        {

            while (true)
            {
                Console.WriteLine("Welcome to Promotion Engine.......\n");
                Console.WriteLine("SKU List.");
                //print the SKU list
                var skuList = skuRepository.getSkuList();
                Console.WriteLine("Id\t\tSKU\t\tPrice");
                foreach (var item in skuList)
                {
                    Console.WriteLine("{0}\t\t{1}\t\t{2}", item.Id, item.SkuName, item.price);
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
                    Console.WriteLine("{0}\t\t\t{1}*{3}\t\t{2}\n", item.SkuName, item.price, item.TotalPrice, item.itemCount);
                }
                Console.WriteLine("Total.\t\t\t\t\t{0}", cartRepository.getOrderTotal());
                Console.WriteLine("Please enter SKU id to add new item in cart or enter c to close.");
                int skuId = 0;
                string input = Console.ReadLine();
                bool result = int.TryParse(input, out skuId);

                //clear the screen. 
                Console.Clear();
                if (result)
                {
                    cartRepository.addSku(skuId);
                    //get the order list from cart and apply promotion.
                    promotionRepository.applyPromotionPrice(cartRepository.getList());
                }
                else
                {
                    Console.WriteLine("Invalid Input.");
                }

            }
        }
    }
}
