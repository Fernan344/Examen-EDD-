using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_problema_9
{
    class Program
    {
        static ArrayList numeros = new ArrayList();

        static void Main(string[] args)
        {
            numeros.Add(5);
            numeros.Add(8);
            numeros.Add(150);
            numeros.Add(230);
            numeros.Add(225);
            numeros.Add(2596);
            numeros.Add(1);
            numeros.Add(0);
            numeros.Add(669);
            numeros.Add(68);
            numeros.Add(52);
            numeros.Add(1);
            numeros.Add(25);
            numeros.Add(2);
            numeros.Add(8);
            numeros.Add(15);
            numeros.Add(45);
            ordenar();
            imprimir();
            string opcion;
            opcion = Console.ReadLine();
        }

        private static void ordenar()
        {
            int t;
            for (int a = 1; a < numeros.Count; a++)
            {
                for (int b = numeros.Count - 1; b >= a; b--)
                {
                    if ((int)(numeros[b - 1]) > (int)numeros[b])
                    {
                        t = (int)(numeros[b - 1]);
                        numeros[b - 1] = numeros[b];
                        numeros[b] = t;
                    }
                }
            }
        }

        private static void imprimir()
        {            
            for (int a = 0; a < numeros.Count; a++)
            {
                Console.WriteLine(numeros[a]);
            }
                
        }
    }
}
