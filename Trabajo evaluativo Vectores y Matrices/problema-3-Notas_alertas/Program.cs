using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problema 3 – Notas y alertas (Matriz m×k + vectores)
//Con m estudiantes y k asignaturas, construir una matriz de notas. Calcular promedios por
//estudiante y asignatura, identificar top y asignatura más exigente, y generar alertas para
//estudiantes con promedio < 3.0.
//Análisis requerido: diseño modular y complejidad.

namespace Notas_MxK
{
    class Program
    {
        static void Main(string[] args)
        {
            //-----------------------Vector estudiantes--------------------------------
            Console.WriteLine("Ingrese el NUMERO de estudiantes: ");
            int tamañoEstudiantes = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            string[] m = new string[tamañoEstudiantes];
            Console.WriteLine("Ingrese el nombre de los estudiantes: ");
            for (int h = 0; h < m.Length; h++)
            {
                m[h] = Console.ReadLine();
            }
            Console.Clear();
            Console.WriteLine("Estudiantes: ");
            for (int z = 0; z < m.Length; z++)
            {
                Console.WriteLine(m[z]);
            }

            //--------------------Vector asignaturas------------------------------------
            Console.WriteLine("Ingrese el NUMERO de asignaturas: ");
            int tamañoAsignaturas = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            string[] k = new string[tamañoAsignaturas];
            Console.WriteLine("Ingrese el nombre de las asignaturas: ");
            for (int n = 0; n < k.Length; n++)
            {
                k[n] = Console.ReadLine();
            }
            Console.Clear();
            Console.WriteLine("Asignaturas: ");
            for (int o = 0; o < k.Length; o++)
            {
                Console.WriteLine(k[o]);
            }
            Console.WriteLine();
            //----------------------------creacion de la matriz-------------------------
            int[,] matriz = new int[m.Length, k.Length];

            //llenar matriz
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.WriteLine($"Ingrese la nota de {m[i]} en {k[j]}");
                    matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("La matriz es: ");
            for (int p = 0; p < matriz.GetLength(0); p++)
            {
                for (int l = 0; l < matriz.GetLength(1); l++)
                {
                    Console.Write("[" + matriz[p, l] + "]");
                }
                Console.WriteLine();
            }
            //--------------------------Promedio de los estudiantes y alertas----------------------------
            Console.WriteLine();
            Console.WriteLine("Promedio de los estudiantes: ");
            Console.WriteLine();


            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                double suma = 0;
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    suma += matriz[i, j];
                }
                double promedioEstudiantes = suma / matriz.GetLength(1);
                Console.WriteLine($"El promedio de {m[i]} es: " + promedioEstudiantes.ToString("0.00"));
                if (promedioEstudiantes < 3.0)
                {
                    Console.WriteLine($"===== ALERTA ==== {m[i]} está en riesgo (promedio" + promedioEstudiantes.ToString("0.00") + ")");
                }

            }
            //-----------------------Promedio por asignaturas----------------------------------
            Console.WriteLine();
            Console.WriteLine("Promedio de asignaturas: ");
            Console.WriteLine();
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                double suma = 0;
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    suma += matriz[i, j];
                }
                double promedioAsignaturas = suma / matriz.GetLength(0);
                Console.WriteLine($"El promedio de {k[j]} es: " + promedioAsignaturas.ToString("0.00"));
            }
            Console.WriteLine();
            //-----------------------------Estudiante top---------------------------------------
            double topIndice = 0;
            int estudianteTop = 0;
            for (int n = 0; n < matriz.GetLength(0); n++)
            {
                double suma = 0;
                for (int h = 0; h < matriz.GetLength(1); h++)
                {
                    suma += matriz[n, h];
                }
                double promedio = suma / matriz.GetLength(1);
                if (promedio > topIndice)
                {
                    topIndice = promedio;
                    estudianteTop = n;
                }
            }
            Console.WriteLine($"El estudiante top es {m[estudianteTop]} con promedio de " + topIndice.ToString("0.00"));

            //---------------------------Asignatura mas exigente----------------------------------
            double indiceAsignatura = 0;
            int asignaturaExigente = 0;

            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                double suma = 0;
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    suma += matriz[i, j];
                }
                double promedio = suma / matriz.GetLength(0);

                if (j == 0 || promedio < indiceAsignatura)
                {
                    indiceAsignatura = promedio;
                    asignaturaExigente = j;
                }
            }
            Console.WriteLine($"La asignatura más exigente es {k[asignaturaExigente]} con promedio de {indiceAsignatura:0.00}");
        }
    }
}