using System.Collections.Generic;

namespace Proxy
{
    class Shop : IShop
    {
        Dictionary<string, string> shopInformation = new Dictionary<string, string>();

        public Shop()
        {
            shopInformation.Add("Ключ 1", "Информация 1");
            shopInformation.Add("Ключ 2", "Информация 2");
            shopInformation.Add("Ключ 3", "Информация 3");
            shopInformation.Add("Ключ 4", "Информация 4");
            shopInformation.Add("Ключ 5", "Информация 5");
        }

        public string GetInfo(string key)
        {
            return shopInformation.ContainsKey(key) ? shopInformation[key] : null;
        }
    }
}
