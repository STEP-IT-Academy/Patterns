using System;
using System.Collections.Generic;

namespace Composite
{
    /// <summary>
    /// Класс для создания файловой системы
    /// </summary>
    class FileSystem : Component
    {
        List<Component> disks = new List<Component>();

        public FileSystem(string name) : base(name)
        {

        }

        public override void Add(Component component)
        {
            SizeInMb += component.SizeInMb;
            disks.Add(component);
        }

        public override void Remove(Component component)
        {
            SizeInMb -= component.SizeInMb;
            disks.Remove(component);
        }

        public override void Print()
        {
            Console.WriteLine($"Узел: {Name}");
            Console.WriteLine("Подузлы: ");

            foreach (Component item in disks)
            {
                item.Print();
            }

        }

        public override void ShowSize()
        {
            double tmp = 0.0;

            disks.ForEach((x) => tmp += x.SizeInMb);

            Console.WriteLine($"{Name} занимает {tmp} мб.");
        }

        public override double CalculateTotalSize()
        {
            double result = 0.0;

            foreach (Component item in disks)
            {
                result += item.SizeInMb;
            }

            return result;
        }
    }
}
