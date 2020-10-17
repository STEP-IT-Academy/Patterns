namespace AbstrcatFactory.Interfaces
{
    interface IFurnitureFactory : IChair, ICoffeTable, ISofa
    {
        IChair CreateChair();

        ICoffeTable CreateCoffeTable();

        ISofa CreateSofa();
    }
}
