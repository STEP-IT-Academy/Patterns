using AbstrcatFactory.Interfaces;
using System;

namespace AbstrcatFactory.CoffeTable
{
    class ArtDecoCoffeTable : ICoffeTable
    {
        public ArtDecoCoffeTable()
        {
            Console.WriteLine("Создан стол в стиле Ар-деко");
        }
    }
}
