using Decorator.Pizza_s;
using Decorator.Pizza_s_Decorators;
using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Допустим, у нас есть пиццерия, которая готовит различные типы пицц с различными добавками. 
             * Есть итальянская, болгарская пиццы. К ним могут добавляться помидоры, сыр и т.д. 
             * И в зависимости от типа пицц и комбинаций добавок пицца может иметь разную стоимость.
             */

            // Готовим итальянскую пиццу
            Pizza pizza1 = new ItalianPizza();

            // Убеждаемся, что это итальянская пицца и узнаем ее стоимость
            Console.WriteLine(pizza1.Name + " стимостью " + pizza1.GetCost() + " рублей");

            // Добавляем начинку к итальянской пицце в качестве томатов и узнаем новую стоимость
            pizza1 = new Tomato(pizza1);
            Console.WriteLine(pizza1.Name + " стимостью " + pizza1.GetCost() + " рублей");

            // Готовим японскую пиццу
            Pizza pizza2 = new JapanPizza();

            // Убеждаемся, что это японская пицца и узнаем ее стоимость
            Console.WriteLine(pizza2.Name + " стимостью " + pizza2.GetCost() + " рублей");

            // Добавляем начинку к японской пицце в виде томатов и сыра и узнаем ее новую стоимость
            pizza2 = new Tomato(pizza2);
            pizza2 = new Cheese(pizza2);
            Console.WriteLine(pizza2.Name + " стимостью " + pizza2.GetCost() + " рублей");

            Console.ReadKey();
        }
    }
}