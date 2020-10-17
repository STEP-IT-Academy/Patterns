namespace Patterns
{
    /// <summary>
    /// Класс внедорожных автомобилей, которые умеют создавать конкретные внедорожных авто
    /// </summary>
    class OffRoadCar : IVehicleBuilder
    {
        Vehicle offRoadCar = new Vehicle("Внедорожник Mercedes M-Class (GLE)");

        public void SetBody()
        {
            offRoadCar.Add("Кузов", "Информация о кузове");
        }

        public void SetColor()
        {
            offRoadCar.Add("Покраска", "Информация о покраске");
        }

        public void SetEngine()
        {
            offRoadCar.Add("Двигатель", "Информация о двигателе");
        }

        public void SetVehicleInterior()
        {
            offRoadCar.Add("Подготовка салона", "Информация о салоне");
        }

        public void SetWheel()
        {
            offRoadCar.Add("Колеса", "Информация о колесах");
        }

        public void ShowResult()
        {
            offRoadCar.ShowVehicleInfo();
        }
    }
}
