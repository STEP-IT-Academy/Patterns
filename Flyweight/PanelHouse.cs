using System;

namespace Flyweight
{
    /// <summary>
    /// Класс для постройки панельного дома
    /// </summary>
    class PanelHouse : House
    {
        /// <summary>
        /// В конструкторе экземпляра задаем изначальное кол-во этажей = 16
        /// </summary>
        public PanelHouse()
        {
            Stages = 16;
        }

        /// <summary>
        /// Постройка дома по указанным кооридинатам долготы и широты
        /// </summary>
        /// <param name="longitude"></param>
        /// <param name="latitude"></param>
        public override void BuildHouse(double longitude, double latitude)
        {
            Console.WriteLine($"Построен панельный дом из 16 этажей с координатами {longitude} широты и {latitude} долготы.");
        }
    }
}
