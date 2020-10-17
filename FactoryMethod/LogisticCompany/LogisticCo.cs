namespace FactoryMethod.LogisticCompany
{
    class LogisticCo
    {
        public static void MakeDelivery(ILogisticsType logisticsType)
        {
            logisticsType.Delivery();
        }
    }
}
