using AbstrcatFactory.Interfaces;
using System;

namespace AbstrcatFactory.CoffeTable
{
    class ModernCoffeTable : ICoffeTable
    {
        public ModernCoffeTable()
        {
            Console.WriteLine("Создан стол в стиле Модерн");
        }
    }
}
