using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casais_Tp2_Pt1__ARBOLES_
{
    public class Nodo
    {
        public string Nombre { get; set; }
        public Nodo(string nombre)
        {
            Nombre = nombre;
        }

        public Nodo Derecha { get; set; }
        public Nodo Izquierda { get; set; }
    }
}
