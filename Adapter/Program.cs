using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            RoundHole hole = new RoundHole { Radius = 5 };
            RoundPeg rpeg = new RoundPeg { Radius = 5 };
            if (hole.Fits(rpeg)) Console.WriteLine("тру");
            else Console.WriteLine("фолс");

            SquarePeg small_sqpeg = new SquarePeg { Width = 2 };
            SquarePeg large_sqpeg = new SquarePeg { Width = 9 };
            //hole.Fits(small_sqpeg);

            SquarePegAdapter small_sqpeg_adapter = new SquarePegAdapter(small_sqpeg);
            SquarePegAdapter large_sqpeg_adapter = new SquarePegAdapter(large_sqpeg);
            if(hole.Fits(small_sqpeg_adapter)) Console.WriteLine("тру");
            else Console.WriteLine("фолс");

            if(hole.Fits(large_sqpeg_adapter)) Console.WriteLine("тру");
            else Console.WriteLine("фолс");

            Console.ReadKey();
        }
    }
}
