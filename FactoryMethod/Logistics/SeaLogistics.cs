using FactoryMethod.Transport;
using System;

namespace FactoryMethod.Logistics
{
    class SeaLogistics : ILogisticsType
    {
        public SeaLogistics()
        {
            Console.WriteLine("Доставка по морю");
        }

        public ITransportType Delivery()
        {
            return new Ship();
        }
    }
}
