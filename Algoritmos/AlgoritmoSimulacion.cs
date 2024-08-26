using Microsoft.Office.Interop.Excel;
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
                listaSalida.Add(5 * (i + 1));
            }

            return listaSalida;
        }

        public List<int> GeneradorCongruencial(int a, int c, int m, int x0)
        {
            List<int> listaSalida = new List<int>();
            if (m <= 1)
            {
                MessageBox.Show("m debe de ser mayor a 1.");
                return listaSalida;
            }
            for(int i = 2; i<= Math.Sqrt(m); i++)
            {
                if(m%i ==0)
                {
                    MessageBox.Show("m debe de ser un numero primo");
                    return listaSalida;
                }
            }
            bool entra = true;
            int xi = x0;
            while (entra)
            {
                xi = (a * xi + c) % m;
                if (!listaSalida.Contains(xi))
                {
                    listaSalida.Add((xi + 1) % m);
                }
                else
                {
                    entra = false;
                }
            }
            return listaSalida;
        }
    }
}
