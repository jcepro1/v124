using System;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicov1Y2practica124
{
    class Vector
    {
        //--------------------------------------------
        const int MAX = 50;
        private int[] v;
        private int n;

        // CONSTRUCTOR---------------------------------
        public Vector()
        {
            n = 0;
            v = new int[MAX];
        }

        // CARGAR--------------------------------------
        public void Cargar(int n1, int a, int b)
        {
            Random r = new Random();
            int i;
            n = n1;
            for (i = 1; i <= n; i++)
            {
                v[i] = r.Next(a, b);
            }
        }

        public void Cargar(int ele)
        {
            n++;
            v[n] = ele;
        }

        public void cargardato(int nele)
        {
            n = nele;//JCE
            int num = n;
            for (int i = 1; i <= num; i++)
            {//JCE
                v[i] = Conversions.ToInteger(Interaction.InputBox(" ", " "));
            }
        }

        // DESCARGAR-----------------------------------
        public string Descargar()
        {
            string s = "";
            int i;
            for (i = 1; i <= n; i++)
            {
                s = s + v[i] + " | ";
            }
            return s;
        }

        // AUXILIARES------------------------
        // BUSQUEDA SECUENCIAL-----------------------------------
        public bool SeEncuentra(int nbus)
        {
            int i = 1;
            bool b = false;
            while ((i <= n) && (b == false))
            {
                if (v[i] == nbus)
                {
                    b = true;
                }
                i++;
            }
            return b;
        }

        // ORDENAMIENTO X INTERCAMBIO---------------------------
        public void Inter(int p1, int p2)
        {
            int aux;
            aux = v[p1];
            v[p1] = v[p2];
            v[p2] = aux;
        }
        public void OrdXInter()
        {
            int i, j;
            for (i = 1; i <= n - 1; i++)
            {
                for (j = i + 1; j <= n; j++)
                {
                    if (v[j] < v[i])
                    {
                        Inter(j, i);
                    }
                }
            }
        }



        //PRACTICO 1

        public void InvertirV(int m)
        {
            // Iterar sobre las posiciones múltiplos de m hasta n/2
            for (int i = m; i <= n / 2; i += m)
            {
                // Invertir los elementos en las posiciones múltiplos de m
                int aux = v[i]; // Guardar el valor en v[i] en una variable auxiliar
                v[i] = v[n - i + 1]; // Asignar el valor en la posición simétrica a v[i]
                v[n - i + 1] = aux; // Asignar el valor guardado en la variable auxiliar a la posición simétrica
            }
        }

        //EJERCICIO 1
        //EJERCICIO 2
        //EJERCICIO 3
        //EJERCICIO 4
        //EJERCICIO 5
        //EJERCICIO 6
        //EJERCICIO 7
        //EJERCICIO 8
        //EJERCICIO 9
        //EJERCICIO 10

        //PRACTICO 2

        //EJERCICIO 1
        //EJERCICIO 2
        //EJERCICIO 3
        //EJERCICIO 4
        //EJERCICIO 5
        //EJERCICIO 6
        //EJERCICIO 7
        //EJERCICIO 8
        //EJERCICIO 9
        //EJERCICIO 10
    }
}
