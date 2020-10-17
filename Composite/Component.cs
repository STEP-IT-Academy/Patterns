using System;

namespace Composite
{
    /// <summary>
    /// Определяет интерфейс для всех компонентов в древовидной структуре
    /// </summary>

    abstract class Component
    {
        // Наименование
        public string Name { get; private set; }

        // Размер в мб
        public double SizeInMb { get; set; }

        protected Component(string name, double sizeInMb)
        {
            Name = name;
            SizeInMb = sizeInMb;
        }

        protected Component(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Добавление компонента
        /// </summary>
        /// <param name="components"></param>
        public virtual void Add(Component components) { }

        /// <summary>
        /// Удаление компонента
        /// </summary>
        /// <param name="components"></param>
        public virtual void Remove(Component components) { }

        /// <summary>
        /// Вывод на консоль наименования компонента
        /// </summary>
        public virtual void Print()
        {
            Console.WriteLine(Name);
        }

        /// <summary>
        /// Вывод на консоль размера компонента
        /// </summary>
        public virtual void ShowSize() { }

        /// <summary>
        /// Расчет занимаемого места (в мб.)
        /// </summary>
        /// <returns></returns>
        public abstract double CalculateTotalSize();
    }
}
