using AbstrcatFactory.Interfaces;
using System;

namespace AbstrcatFactory.CoffeTable
{
    class VictorianCoffeTable : ICoffeTable
    {
        public VictorianCoffeTable()
        {
            Console.WriteLine("Создан стол в Викторианском стиле");
        }
    }
}
