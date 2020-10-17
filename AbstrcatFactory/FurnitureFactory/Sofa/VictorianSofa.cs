using AbstrcatFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrcatFactory.Sofa
{
    class VictorianSofa : ISofa
    {
        public VictorianSofa()
        {
            Console.WriteLine("Создан диван в Викторианском стиле");
        }
    }
}
