using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_EDD_P8
{
    class Estudiante
    {
        private string seccion;
        private int carnet;

        public Estudiante(string seccion, int carnet)
        {
            this.seccion = seccion;
            this.carnet = carnet;
        }

        public string getSeccion()
        {
            return this.seccion;
        }

        public int getCarnet()
        {
            return this.carnet;
        }
    }
}
