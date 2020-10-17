namespace Decorator.Pizza_s
{
    abstract class Pizza
    {
        public string Name { get; protected set; }

        protected Pizza(string name)
        {
            Name = name;
        }

        public abstract decimal GetCost();
    }
}
