using System;
using System.Collections.Generic;

namespace Composite
{
    /// <summary>
    /// Класс для создания папки
    /// </summary>
    class Folder : Component
    {
        List<Component> components = new List<Component>();

        public Folder(string name) : base(name) { }

        public override void Add(Component component)
        {
            SizeInMb += component.SizeInMb;
            components.Add(component);
        }

        public override void Remove(Component component)
        {
            SizeInMb -= component.SizeInMb;
            components.Remove(component);
        }

        public override void Print()
        {
            Console.WriteLine($"Узел: {Name}");
            Console.WriteLine("Подузлы: ");

            foreach (Component item in components)
            {
                item.Print();
            }

        }

        public override void ShowSize()
        {
            Console.WriteLine($"{Name} занимает {SizeInMb} мб.");
        }

        public override double CalculateTotalSize()
        {
            double tmp = 0.0;
            components.ForEach((x) => tmp += x.SizeInMb);
            return tmp;
        }
    }
}
