using FactoryMethod.Transport;
using System;

namespace FactoryMethod
{
    class RoadLogistics : ILogisticsType
    {
        public RoadLogistics()
        {
            Console.WriteLine("Доставка по суше");
        }

        public ITransportType Delivery()
        {
            return new Truck();
        }
    }
}
