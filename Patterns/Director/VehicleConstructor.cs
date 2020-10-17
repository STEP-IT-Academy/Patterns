namespace Patterns
{
    /// <summary>
    /// Класс-директор, который с помощью объекта интерфейса-строителя собирает автомобиль
    /// </summary>
    class VehicleConstructor
    {
        public void ConstructVehicle(IVehicleBuilder builder)
        {
            builder.SetBody();
            builder.SetEngine();
            builder.SetWheel();
            builder.SetColor();
            builder.SetVehicleInterior();
        }
    }
}
