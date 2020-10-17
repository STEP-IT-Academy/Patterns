using System;

namespace Composite
{
    /// <summary>
    /// Класс для создания файла
    /// </summary>
    class File : Component
    {
        public File(string name, double sizeInMb) : base(name, sizeInMb) { }

        public override double CalculateTotalSize()
        {
           return SizeInMb;
        }

        public override void ShowSize()
        {
            Console.WriteLine($"{Name} занимает {SizeInMb} мб.");
        }
    }
}