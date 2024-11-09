using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casais_Tp2_Pt2__ARCHIVOS_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Base de datos simulada
            
            List<Tarjeta> tarjetasDB = new List<Tarjeta>
            {
                new Tarjeta("1234", 3500),
                new Tarjeta("4321", 5788),
                new Tarjeta("9999", 5500)
            };

            // Lista 
            List<string> resultados = new List<string> { "NroTarjeta;SaldoConsolidado;Diferencia" };
           

            string[] lineasArchivo = File.ReadAllLines("Tarjetas.txt");


            for (int i = 1; i < lineasArchivo.Length; i++)
            {
                
                string[] campos = lineasArchivo[i].Split(';');
                
                string numeroTarjeta = campos[0];
                
                int saldoArchivo = int.Parse(campos[2]);

                
                Tarjeta tarjetaDB = tarjetasDB.Find(t => t.Numero == numeroTarjeta);

                if (tarjetaDB != null)
                {
                    
                    string saldoConsolidado;
                   
                    if (saldoArchivo == tarjetaDB.SaldoDB)
                    {
                        saldoConsolidado = "SI";
                    }
                    else
                    {
                        saldoConsolidado = "NO";
                    }

                    int diferencia = saldoArchivo - tarjetaDB.SaldoDB;
                    
                    string diferenciaConSigno;

                    if (diferencia > 0)
                    {
                        diferenciaConSigno = "+" + diferencia;
                    }
                    else
                    {
                        diferenciaConSigno = diferencia.ToString();
                    }

                    resultados.Add($"{numeroTarjeta};{saldoConsolidado};{diferenciaConSigno}");

                }
            }

            //creacion de Consolidado.txt
            File.WriteAllLines("Consolidado.txt", resultados);
        }

    }
    
}
