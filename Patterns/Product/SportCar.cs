namespace Patterns
{
    /// <summary>
    /// Класс спортивных автомобилей, которые умеют создавать конкретные спортивные авто
    /// </summary>
    class SportCar : IVehicleBuilder
    {
        Vehicle sportCar = new Vehicle("Спортивный автомобиль Audi R8");

        public void SetBody()
        {
            sportCar.Add("Кузов", "Информация о кузове");
        }

        public void SetColor()
        {
            sportCar.Add("Покраска", "Информация о покраске");
        }

        public void SetEngine()
        {
            sportCar.Add("Двигатель", "Информация о двигателе");
        }

        public void SetVehicleInterior()
        {
            sportCar.Add("Подгтовка салона", "Инфрмация о салоне");
        }

        public void SetWheel()
        {
            sportCar.Add("Колеса", "Информация о колесах");
        }

        public void ShowResult()
        {
            sportCar.ShowVehicleInfo();
        }
    }
}
