using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casais_Tp2_Pt2__ARCHIVOS_
{
    internal class Tarjeta
    {
        public string Numero { get; set; }
        public int SaldoDB { get; set; }

        public Tarjeta(string numero, int saldoDB)
        {
            Numero = numero;
            SaldoDB = saldoDB;
        }

    }
}
