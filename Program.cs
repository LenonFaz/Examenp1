using PROMEDIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROMEDIO
{
    class Program
    {
        static void Main(string[] args)
        {
            int jugar = 1;
            while (jugar == 1)
            {
                Console.WriteLine("crea tu personaje");
                int vj = 0;
                int dj = 0;

                while (true)
                {
                    Console.WriteLine("vida (max 100):");
                    vj = int.Parse(Console.ReadLine());
                    Console.WriteLine("dmg (max 100):");
                    dj = int.Parse(Console.ReadLine());
                    if (vj <= 100 && dj <= 100)
                    {
                        break;
                    }
                    Console.WriteLine("no puede pasar de 100");
                }

                jugador j = new jugador(vj, dj);

                Console.WriteLine("cuantos enemigos?:");
                int cant = int.Parse(Console.ReadLine());
                List<enemigo> lista = new List<enemigo>();

                for (int i = 0; i < cant; i++)
                {
                    Console.WriteLine("vida enemigo " + i + ":");
                    int ve = int.Parse(Console.ReadLine());
                    Console.WriteLine("dmg enemigo " + i + ":");
                    int de = int.Parse(Console.ReadLine());
                    lista.Add(new enemigo(ve, de));
                }

                while (j.vida > 0)
                {
                    int vivos = 0;
                    for (int i = 0; i < lista.Count; i++)
                    {
                        if (lista[i].vivo())
                        {
                            vivos = vivos + 1;
                        }
                    }

                    if (vivos == 0)
                    {
                        Console.WriteLine("victoria");
                        break;
                    }

                    Console.WriteLine("tu vida: " + j.vida);
                    for (int i = 0; i < lista.Count; i++)
                    {
                        if (lista[i].vivo())
                        {
                            Console.WriteLine(i + " enemigo vida: " + lista[i].vida);
                        }
                        else
                        {
                            Console.WriteLine(i + " enemigo muerto");
                        }
                    }

                    Console.WriteLine("numero de enemigo a atacar:");
                    int op = int.Parse(Console.ReadLine());

                    if (op >= 0 && op < lista.Count)
                    {
                        if (lista[op].vivo())
                        {
                            lista[op].recibirdmg(j.dardmg());

                            for (int i = 0; i < lista.Count; i++)
                            {
                                if (lista[i].vivo())
                                {
                                    j.recibirdmg(lista[i].dardmg());
                                    Console.WriteLine("enemigo " + i + " te ataco");
                                    break;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("ya esta muerto");
                        }
                    }
                }

                if (j.vida <= 0)
                {
                    Console.WriteLine("derrota");
                }

                Console.WriteLine("otra vez? 1 si, 0 no");
                jugar = int.Parse(Console.ReadLine());
            }
        }
    }
}