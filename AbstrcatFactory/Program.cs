using AbstrcatFactory.Factories;
using System;

namespace AbstrcatFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            ArtDecoFurnitureFactory artDecoFurnitureFactory = new ArtDecoFurnitureFactory();
            ModernFurnitureFactory modernFurnitureFactory = new ModernFurnitureFactory();
            VictorianFurnitureFactory victorianFurnitureFactory = new VictorianFurnitureFactory();

            Console.ReadKey();
        }
    }
}