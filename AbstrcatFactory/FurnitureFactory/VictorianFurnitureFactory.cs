using AbstrcatFactory.Chair;
using AbstrcatFactory.CoffeTable;
using AbstrcatFactory.Interfaces;
using AbstrcatFactory.Sofa;

namespace AbstrcatFactory.Factories
{
    class VictorianFurnitureFactory : IFurnitureFactory
    {
        public VictorianFurnitureFactory()
        {
            CreateChair();
            CreateCoffeTable();
            CreateSofa();
        }
        public IChair CreateChair()
        {
            return new VictorianChair();
        }

        public ICoffeTable CreateCoffeTable()
        {
            return new VictorianCoffeTable();
        }

        public ISofa CreateSofa()
        {
            return new VictorianSofa();
        }
    }
}
