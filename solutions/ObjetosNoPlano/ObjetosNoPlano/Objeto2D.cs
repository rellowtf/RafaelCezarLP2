﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosNoPlano
{
    class Objeto2D
    {
        public int x;
        public int y;

        public void AndarParaADireita()
        {
            x+=1;
        }

        public string Coordenadas()
        {
            return String.Format("({0}, {1})", x, y);
        }

    }
}
