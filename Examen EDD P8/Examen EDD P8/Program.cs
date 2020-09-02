using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Examen_EDD_P8
{
    class Program
    {
        static ArrayList estudiantes = new ArrayList();

        static void Main(string[] args)
        {
            int opcion = 0;
            while (opcion != 4) {
                Console.WriteLine("1-Ingresar Datos \n"+
                    "2-Eliminar Datos \n"+
                    "3-Imprimir");
                opcion = int.Parse(Console.ReadLine());
                String seccion;
                String carnet;
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Introduzca la seccion");
                        seccion = Console.ReadLine();
                        Console.WriteLine("Introduzca el carnet");
                        carnet = Console.ReadLine();
                        insertar(seccion, int.Parse(carnet));
                        break;
                    case 2:
                        Console.WriteLine("Introduzca la seccion");
                        seccion = Console.ReadLine();
                        Console.WriteLine("Introduzca el carnet");
                        carnet = Console.ReadLine();
                        eliminar(seccion, int.Parse(carnet));
                        break;
                    case 3:
                        for (int i = 0; i<estudiantes.Count; i++)
                        {
                            Estudiante est = (Estudiante)estudiantes[i];
                            Console.WriteLine(est.getCarnet()+"-"+est.getSeccion());
                        }
                        break;
                }
            }
        }

        private static void insertar(string seccion, int carnet)
        {
            Estudiante est = new Estudiante(seccion, carnet);
            estudiantes.Add(est);

            Estudiante t;
            for (int a = 1; a < estudiantes.Count; a++)
            {
                for (int b = estudiantes.Count - 1; b >= a; b--)
                {
                    Estudiante est1 = (Estudiante)estudiantes[b];
                    Estudiante est2 = (Estudiante)estudiantes[b-1];
                    if (est2.getCarnet() > est1.getCarnet())
                    {
                        t = est2;
                        estudiantes[b - 1] = estudiantes[b];
                        estudiantes[b] = t;
                    }
                }
            }
        }

        private static void eliminar(string seccion, int carnet)
        {
            int position = 0;
            int max = estudiantes.Count;
            int min = 0;
            bool encontrado = false;
            while (min <= max)
            {
                Estudiante busqueda = new Estudiante(seccion, carnet);
                Estudiante obtener = (Estudiante)estudiantes[position];
                position = (max + min) / 2;
                if (busqueda.getCarnet() == obtener.getCarnet() && busqueda.getSeccion()==busqueda.getSeccion())
                {
                    estudiantes.RemoveAt(position);
                    encontrado = true;
                    break;
                }
                else if (obtener.getCarnet() > carnet)
                {
                    max = position - 1;
                }
                else
                    min = position + 1;

            }
            if (encontrado)
            {
                Console.WriteLine("The element is in position: " + (position + 1));
            }
            else
            {
                Console.WriteLine("The element was not found");
            }
        }    
    }
}
