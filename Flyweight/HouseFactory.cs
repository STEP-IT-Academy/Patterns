using System.Collections.Generic;

namespace Flyweight
{
    class HouseFactory
    {
        /// <summary>
        /// Словарь, в котором ключ - тип дома(кирпичный или панельный), а значение - конкретный дом
        /// </summary>
        Dictionary<string, House> houses = new Dictionary<string, House>();

        /// <summary>
        /// Создаем два объекта дома для каждого конкретного приспособленца
        /// </summary>
        public HouseFactory()
        {
            houses.Add("Панельный", new PanelHouse());
            houses.Add("Кирпичный", new BrickHouse());
        }
        
        /// <summary>
        /// Возвращаем дом в зависимости от переданного параметра
        /// </summary>
        /// <param name="keyAsHouseKind"></param>
        /// <returns></returns>
        public House GetHouse(string keyAsHouseKind)
        {
            return houses.ContainsKey(keyAsHouseKind) ? houses[keyAsHouseKind] : null;
        }
    }
}
