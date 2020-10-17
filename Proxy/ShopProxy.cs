using System;

namespace Proxy
{
    class ShopProxy : IShop
    {
        Shop shop;

        static int brut = 0;

        public string GetInfo(string key)
        {
            Lazy<Shop> lazyShop = new Lazy<Shop>();

            // Brute force будем считать > 10 неправильных попыток ввода пароля

            if (lazyShop.Value.GetInfo(key) != null && brut < 10)
            {
                shop = new Shop();
                return shop.GetInfo(key);
            }
            else
            {
                ++brut;
            }

            if (brut > 10)
            {
                Console.WriteLine("Завершена работа программы. Была попытка полного перебора пароля.");
                Console.ReadKey();
                Environment.Exit(0);
            }

            return null;
        }
    }
}
