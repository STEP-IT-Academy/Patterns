﻿using AbstrcatFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrcatFactory.Sofa
{
    class ArtDecoSofa : ISofa
    {
        public ArtDecoSofa()
        {
            Console.WriteLine("Создан диван в стиле Ар-деко");
        }
    }
}
