namespace Adapter
{
    class RoundHole
    {
        public int Radius { get; set; }

        public int GetRadius => Radius;

        public bool Fits(RoundPeg peg) => GetRadius >= peg.GetRadius;
    }
}
