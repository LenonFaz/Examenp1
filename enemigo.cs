using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROMEDIO
{
    class enemigo
    {
        public int vida;
        public int dmg;

        public enemigo(int v, int d)
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

        public bool vivo()
        {
            if (vida > 0)
            {
                return true;
            }
            return false;
        }
    }
}