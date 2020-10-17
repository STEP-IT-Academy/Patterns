namespace Patterns
{
    /// <summary>
    /// Класс мини-автомобилей, которые умеют создавать конкретные мини-авто
    /// </summary>
    class MiniCar : IVehicleBuilder
    {
        Vehicle miniCar = new Vehicle("Мини-автомобиль Volkswagen Polo хэтчбек");

        public void SetBody()
        {
            miniCar.Add("Кузов", "Информация о кузове");
        }

        public void SetColor()
        {
            miniCar.Add("Покраска", "Информация о покраске");
        }

        public void SetEngine()
        {
            miniCar.Add("Двигатель", "Информация о двигателе");
        }

        public void SetVehicleInterior()
        {
            miniCar.Add("Подготовка салона", "Информация о салоне");
        }

        public void SetWheel()
        {
            miniCar.Add("Колеса", "Информация о колесах");
        }

        public void ShowResult()
        {
            miniCar.ShowVehicleInfo();
        }
    }
}
