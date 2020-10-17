using AbstrcatFactory.Chair;
using AbstrcatFactory.CoffeTable;
using AbstrcatFactory.Interfaces;
using AbstrcatFactory.Sofa;

namespace AbstrcatFactory.Factories
{
    class ArtDecoFurnitureFactory : IFurnitureFactory
    {
        public ArtDecoFurnitureFactory()
        {
            CreateChair();
            CreateCoffeTable();
            CreateSofa();
        }

        public IChair CreateChair()
        {
            return new ArtDecoChair();
        }

        public ICoffeTable CreateCoffeTable()
        {
            return new ArtDecoCoffeTable();
        }

        public ISofa CreateSofa()
        {
            return new ArtDecoSofa();
        }
    }
}
