using FactoryMethod.LogisticCompany;
using FactoryMethod.Logistics;
using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogisticsType logisticsType;

            logisticsType = new RoadLogistics();
            LogisticCo.MakeDelivery(logisticsType);

            logisticsType = new SeaLogistics();
            LogisticCo.MakeDelivery(logisticsType);

            Console.ReadKey();
        }
    }
}
