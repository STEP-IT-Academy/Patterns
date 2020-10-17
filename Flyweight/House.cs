namespace Flyweight
{
    /// <summary>
    /// Интерфейс(абстр. класс) приспособленца
    /// </summary>
    abstract class House
    {
        /// <summary>
        /// Количество этажей
        /// </summary>
        protected int Stages { get; set; }

        /// <summary>
        /// Постройка дома по указанным кооридинатам долготы и широты
        /// </summary>
        /// <param name="longitude"></param>
        /// <param name="latitude"></param>
        public abstract void BuildHouse(double longitude, double latitude);
    }
}
