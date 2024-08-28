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

        public List<int> GeneradorCongruencial(int a, int c, int m, int x0)
        {
            List<int> listaSalida = new List<int>();
            if (m <= 1)
            {
                MessageBox.Show("m debe de ser mayor a 1.");
                return listaSalida;
            }
            for (int i = 2; i <= Math.Sqrt(m); i++)
            {
                if (m % i == 0)
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
        public List<int> GeneradorCongruencialnoLineal(int a, int c, int m, int x0)
        {
            List<int> listaSalida = new List<int>();
            if (m <= 1)
            {
                MessageBox.Show("m debe de ser mayor a 1.");
                return listaSalida;
            }
            for (int i = 2; i <= Math.Sqrt(m); i++)
            {
                if (m % i == 0)
                {
                    MessageBox.Show("m debe de ser un numero primo");
                    return listaSalida;
                }
            }
            bool entra = true;
            int xi = x0;
            while (entra)
            {
                xi = (a ^ xi * c) % m;
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
        public List<int> GeneradorPuntoMedio(int a, int c, int m, int x0)
        {
            List<int> listaSalida = new List<int>();
            if (m <= 1)
            {
                MessageBox.Show("m debe de ser mayor a 1.");
                return listaSalida;
            }
            for (int i = 2; i <= Math.Sqrt(m); i++)
            {
                if (m % i == 0)
                {
                    MessageBox.Show("m debe de ser un numero primo");
                    return listaSalida;
                }
            }
            bool entra = true;
            int xi = x0;
            while (entra)
            {
                xi = (a ^ xi * c) % m;
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
        public List<int> GeneradorCuadradoMedio(int n, int x0)
        {
            // n: Cantidad de dígitos a considerar
            // x0: Semilla

            List<int> listaSalida = new List<int>();

            int xi = x0;
            int digitos = 0;
            bool corre = true;

            while (corre)
            {
                // Calcular el siguiente elemento:
                // Calcular el cuadrado
                xi = (int)Math.Pow(xi, 2);
                // Calcula la cantidad de dígitos del cuadrado
                digitos = (int)Math.Floor(Math.Log10(xi) + 1);
                // Tumba los últimos
                xi = (int)Math.Floor((double)(xi / Math.Pow(10, Math.Floor((double)((digitos - n) / 2)))));

                // Conserva los siguientes n
                xi = (int)(xi % Math.Pow(10, n));

                if (!listaSalida.Contains(xi))
                {
                    listaSalida.Add(xi);
                }
                else
                {
                    corre = false;
                }

            }

            return listaSalida;

        }
        public List<int> GeneradorProductoMedio(int n, int x0, int x1)
        {
            // n: Cantidad de dígitos a considerar
            // x0: Semilla 0
            // x1: Semilla 1

            List<int> listaSalida = new List<int>();
            listaSalida.Add(x0);
            listaSalida.Add(x1);

            int xi = x1;
            int digitos = 0;
            bool corre = true;

            while (corre)
            {
                // Calcular el siguiente elemento:
                // Calcular el producto de los dos anteriores
                xi = listaSalida[listaSalida.Count - 1] * listaSalida[listaSalida.Count - 2];
                // Calcula la cantidad de dígitos del cuadrado
                digitos = (int)Math.Floor(Math.Log10(xi) + 1);
                // Tumba los últimos
                xi = (int)Math.Floor((double)(xi / Math.Pow(10, Math.Floor((double)((digitos - n) / 2)))));
                // Conserva los siguientes n
                xi = (int)(xi % Math.Pow(10, n));

                // Revisa si ya existía en la lista y lo agrega sino
                if (!listaSalida.Contains(xi))
                {
                    listaSalida.Add(xi);
                }
                else
                {
                    corre = false;
                }

            }

            // Quitar las semillas que se agregaron a la lista al inicio
            listaSalida.RemoveRange(0, 2);
            return listaSalida;

        }
    }
}
