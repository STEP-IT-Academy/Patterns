using System;

namespace Adapter
{
    class SquarePegAdapter : RoundPeg
    {
        SquarePeg peg;

        public SquarePegAdapter(SquarePeg peg)
        {
            this.peg = peg;
        }

        public override int GetRadius => (int)(Math.Sqrt(2 * Math.Pow(peg.GetWidth, 2)) / 2);
    }
}
