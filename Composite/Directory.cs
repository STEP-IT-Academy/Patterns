using System;
using System.Collections.Generic;

namespace Composite
{
    /// <summary>
    /// Класс для сорздания директории
    /// </summary>
    class Directory : Component
    {
        /// <summary>
        /// List компонентов, которые могут содержаться в данной диреткории
        /// </summary>
        List<Component> components = new List<Component>();

        public Directory(string name) : base(name) { }

        /// <summary>
        /// Добавление компонента в директорию
        /// </summary>
        /// <param name="component"></param>
        public override void Add(Component component)
        {
            SizeInMb += component.SizeInMb;
            components.Add(component);
        }

        /// <summary>
        /// Удаление компонента из директории
        /// </summary>
        /// <param name="component"></param>
        public override void Remove(Component component)
        {
            SizeInMb -= component.SizeInMb;
            components.Remove(component);
        }

        /// <summary>
        /// Вывод на консоль наименования директории
        /// </summary>
        public override void Print()
        {
            Console.WriteLine($"Узел: {Name}");
            Console.WriteLine("Подузлы: ");

            foreach (Component item in components)
            {
                item.Print();
            }

        }

        /// <summary>
        /// Вывод на консоль занимаемого места (в мб.)
        /// </summary>
        public override void ShowSize()
        {
            Console.WriteLine($"{Name} занимает {SizeInMb} мб.");
        }

        /// <summary>
        /// Расчет занимаемого места директории
        /// </summary>
        /// <returns></returns>
        public override double CalculateTotalSize()
        {
            double tmp = 0.0;
            components.ForEach((x) => tmp += x.SizeInMb);
            return tmp;
        }
    } 
}
