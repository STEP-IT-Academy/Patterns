using AbstrcatFactory.Interfaces;
using System;

namespace AbstrcatFactory.Chair
{
    class ModernChair : IChair
    {
        public ModernChair()
        {
            Console.WriteLine("Создан стул в стиле Модерн");
        }
    }
}
