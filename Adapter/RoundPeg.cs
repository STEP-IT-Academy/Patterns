namespace Adapter
{
    class RoundPeg
    {
        public int Radius { get; set; }

        public virtual int GetRadius => Radius;
    }
}
