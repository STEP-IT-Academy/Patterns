using AbstrcatFactory.Chair;
using AbstrcatFactory.CoffeTable;
using AbstrcatFactory.Interfaces;
using AbstrcatFactory.Sofa;

namespace AbstrcatFactory.Factories
{
    class ModernFurnitureFactory : IFurnitureFactory
    {
        public ModernFurnitureFactory()
        {
            CreateChair();
            CreateCoffeTable();
            CreateSofa();
        }

        public IChair CreateChair()
        {
            return new ModernChair();
        }

        public ICoffeTable CreateCoffeTable()
        {
            return new ModernCoffeTable();
        }

        public ISofa CreateSofa()
        {
            return new ModernSofa();
        }
    }
}
