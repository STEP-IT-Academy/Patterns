using System;

namespace Patterns
{
    class Client
    {
        static void Main(string[] args)
        {
            try
            {
                // Создаём объект класса-директора
                VehicleConstructor vehicleFactory = new VehicleConstructor();

                // Объявляем переменную интерфейса-строителя (VehicleBuilder) для создания в будующем разных типов авто(мини, спорт, внедорожных)
                IVehicleBuilder builder;

                // Создаем объект интерфейса-строителя. Этот объект умеет создавать мини-автомобили
                builder = new MiniCar();

                // Собираем мини-автомобиль
                vehicleFactory.ConstructVehicle(builder);

                // Выводим информацию о собранном авто на консоль
                builder.ShowResult();

                // Создаем объект интерфейса-строителя. Этот объект умеет создавать спортивные автомобили
                builder = new SportCar();

                // Собираем спортивную машину
                vehicleFactory.ConstructVehicle(builder);

                // Выводим информацию о собранном авто на консоль
                builder.ShowResult();

                // Создаем объект интерфейса-строителя. Этот объект умеет создавать внедорожные автомобили
                builder = new OffRoadCar();

                // Собираем внедорожную машину
                vehicleFactory.ConstructVehicle(builder);

                // Выводим информацию о собранном авто на консоль
                builder.ShowResult();

                Console.CursorVisible = false;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
