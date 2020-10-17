using Decorator.Pizza_s;

namespace Decorator.Pizza_s_Decorators
{
    class Cheese : PizzaDecorator
    {
        public Cheese(Pizza pizza) : base(pizza.Name + ", с сыром", pizza) { }

        public override decimal GetCost()
        {
            // 1 рубль 30 копеек - магическое число, которое добавляется к изначальной стоимости за добавку сыра
            return pizza.GetCost() + 1.3m;
        }
    }
}
