using Decorator.Pizza_s;

namespace Decorator.Pizza_s_Decorators
{
    class Tomato : PizzaDecorator
    {
        public Tomato(Pizza pizza) : base(pizza.Name + ", с томатами", pizza) { }

        public override decimal GetCost()
        {
            // 1 рубль 25 копеек - магическое число, которое добавляется к изначальной стоимости за добавку томатов
            return pizza.GetCost() + 1.25m;
        }
    }
}