namespace Flyweight
{
    /// <summary>
    /// Класс для постройки кирпичного дома
    /// </summary>
    class BrickHouse : House
    {
        /// <summary>
        /// В конструкторе экземпляра задаем изначальное кол-во этажей = 5
        /// </summary>
        public BrickHouse()
        {
            Stages = 5;
        }

        /// <summary>
        /// Постройка дома по указанным кооридинатам долготы и широты
        /// </summary>
        /// <param name="longitude"></param>
        /// <param name="latitude"></param>
        public override void BuildHouse(double longitude, double latitude)
        {
            System.Console.WriteLine($"Построен кирпичный дом из 5 этажей с координатами {longitude} широты и {latitude} долготы.");
        }
    }
}
