using Decorator.Pizza_s;

namespace Decorator.Pizza_s_Decorators
{
    abstract class PizzaDecorator : Pizza
    {
        protected Pizza pizza;

        public PizzaDecorator(string pizzaName, Pizza pizza) : base(pizzaName)
        {
            this.pizza = pizza;
        }
    }
}
