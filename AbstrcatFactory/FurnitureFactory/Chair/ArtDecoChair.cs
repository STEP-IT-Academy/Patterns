using AbstrcatFactory.Interfaces;
using System;

namespace AbstrcatFactory.Chair
{
    class ArtDecoChair : IChair
    {
        public ArtDecoChair()
        {
            Console.WriteLine("Создан стул в стиле Ар-деко");
        }
    }
}
