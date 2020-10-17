using System;

namespace Prototype
{
    class Shape : ICloneable
    {
        public int X { get; set; }

        public int Y { get; set; }

        public string Color { get; set; }

        public object Clone()
        {
            Shape clone = (Shape)MemberwiseClone();
            if(clone.Color != null) clone.Color = string.Copy(Color);
            return clone;
        }
    }
}
