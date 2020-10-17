using FactoryMethod.Transport;

namespace FactoryMethod
{
    interface ILogisticsType
    {
        ITransportType Delivery();
    }
}
