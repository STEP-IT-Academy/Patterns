using System;

namespace FactoryMethod.Transport
{
    class Ship : ITransportType
    {
        public Ship()
        {
            Console.WriteLine("Используется корбаль");
        }
    }
}
