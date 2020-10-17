using AbstrcatFactory.Interfaces;
using System;

namespace AbstrcatFactory.Chair
{
    class VictorianChair : IChair
    {
        public VictorianChair()
        {
            Console.WriteLine("Создан стул в Викторианском стиле");
        }
    }
}
