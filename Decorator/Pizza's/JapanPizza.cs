namespace Decorator.Pizza_s
{
    class JapanPizza : Pizza
    {
        public JapanPizza() : base("Японская пицца") { }

        public override decimal GetCost()
        {
            // 5 (рублей) - магическое число
            return 5m;
        }
    }
}
