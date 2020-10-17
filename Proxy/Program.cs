using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {

            ShopProxy shopProxy = new ShopProxy();
            string information;

            do
            {
                Console.Write("Введите пароль: ");
                string password = Console.ReadLine();
                information = shopProxy.GetInfo(password);

            } while (information == null);

            Console.WriteLine("Запрашиваемая вами информация: " + information);
            Console.ReadKey();
        }
    }
}
