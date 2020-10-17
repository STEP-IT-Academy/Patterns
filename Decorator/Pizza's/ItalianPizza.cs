namespace Decorator.Pizza_s
{
    class ItalianPizza : Pizza
    {
        public ItalianPizza() : base("Итальянская пицца") { }

        public override decimal GetCost()
        {
            // 5 (рублей) - магическое число
            return 10m;
        }
    }
}
