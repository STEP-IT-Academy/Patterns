using System;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Применение паттерна Flyweight
             * Допустим, мы проектируем программу для моделирования города. Город состоит из отдельных домов, поэтому нам надо создать объекты этих домов.
             * Однако домов в городе может быть множество: сотни, тысячи. Они могут иметь разный вид, отличаться по различным признакам.
             * Однако, как правило, многие дома делаются по стандартным проектам. 
             * И фактически мы можем выделить несколько типов домов, например, пятиэтажные кирпичные хрущевки, многоэтажные панельные высотки и так далее.
             */

            // Задаем широту и долготу
            double longitude = 29.11;
            double latitude = 71.31;

            // Создаем фабрику домов
            HouseFactory houseFactory = new HouseFactory();

            // Строим 5 панельных домов
            for (int i = 0; i < 5; i++)
            {
                House panelHouse = houseFactory.GetHouse("Панельный");
                panelHouse?.BuildHouse(longitude, latitude);

                longitude += 0.1;
                latitude += 0.1;
            }

            // Строим 5 кирпичных домов
            for (int i = 0; i < 5; i++)
            {
                House brickHouse = houseFactory.GetHouse("Кирпичный");
                brickHouse?.BuildHouse(longitude, latitude);

                longitude += 0.1;
                latitude += 0.1;
            }

            Console.ReadKey();
        }
    }
}
