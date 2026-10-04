using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROMEDIO
{
    class jugador
    {
        public int vida;
        public int dmg;

        public jugador(int v, int d)
        {
            vida = v;
            dmg = d;
        }

        public void recibirdmg(int d)
        {
            vida = vida - d;
        }

        public int dardmg()
        {
            return dmg;
        }
    }
}