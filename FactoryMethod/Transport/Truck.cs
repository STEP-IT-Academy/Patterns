using System;

namespace FactoryMethod.Transport
{
    class Truck : ITransportType
    {
        public Truck()
        {
            Console.WriteLine("Используется грузовик");
        }
    }
}
