using System;
using System.Collections.Generic;

namespace Patterns
{
    class Vehicle 
    {
        /// <summary>
        /// Тип автомобиля
        /// </summary>
        string vehicleType;

        /// <summary>
        /// Хранилище информации о конкретной части авто
        /// </summary>
        Dictionary<string,string> parts = new Dictionary<string,string>();

        public Vehicle(string vehicleType)
        {
            this.vehicleType = vehicleType;
        }

        /// <summary>
        /// Установка значения для конкретной части авто
        /// </summary>
        /// <param name="typeOfpart"></param>
        /// <param name="nameOfPart"></param>
        public void Add(string typeOfpart, string nameOfPart)
        {
            parts.Add(typeOfpart, nameOfPart);
        }

        /// <summary>
        /// Отображение информации об автомобиле
        /// </summary>
        public void ShowVehicleInfo()
        {
            Console.WriteLine(vehicleType + "\n");

            foreach (KeyValuePair<string,string> item in parts)
            {
                Console.WriteLine(item.Key + "; " + item.Value + ".");
            }

            Console.WriteLine();
        }
    }
}
