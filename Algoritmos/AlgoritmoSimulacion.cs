using Prueba1908.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba1908.Algoritmos
{
    public class AlgoritmoSimulacion
    {
        //public List<Gen> GeneradorValores(int poblacion, double probCruce)

        public List<int> GeneradorValores(int n)
        { 
            List<int> listaSalida = new List<int>();
            for (int i = 0; i < n; i++)
            {
                listaSalida.Add(5*(i+1));
            }

            return listaSalida;

            //List<Gen> listaAleatorios = new List<Gen>();
            //for (int i = 0; ; i < poblacion; int++){
            //    Gen genAleatorio = new Gen();
            //    genAleatorio.Id = int;
            //    Random randProb = new Random();
            //    double aux= randProb.NextDouble();
            //    if (aux < probCruce)
            //    {
            //        genAleatorio.Genome = 1;
            //    }
            //    else {
            //        genAleatorio.Genome = 0;
            //    }
            //    listaAleatorios.Add(genAleatorio);
            //return listaAleatorios;
        }
    }
}
