using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapaVentas
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] arrayProductos = { "Papa", "Arroz", "Carne", "Cafe" };
            string[] arrayDias = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes" };
            int[,] ventas = {
                {45000, 72000, 19000, 83000, 56000}, //Producto 0
                {33000, 91000, 64000, 27000, 78000}, //Producto 1
                {88000, 41000, 95000, 36000, 62000}, //Producto 2
                {76000, 23000, 51000, 69000, 14000} //Producto 3
            };
            for (int n = 0; n < arrayProductos.Length; n++)
            {
                for (int k = 0; k < arrayDias.Length; k++)
                {
                    Console.Write("[" + ventas[n, k] + "]");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            //---------------------Total por producto----------------------------------
            Console.WriteLine("==============Total en la semana por producto=========\n");
            for (int i = 0; i < arrayProductos.Length; i++)
            {
                int sumaP = 0;
                for (int o = 0; o < arrayDias.Length; o++)
                {
                    sumaP += ventas[i, o];
                }
                Console.WriteLine($"Total producto {arrayProductos[i]} en la semana:" + sumaP + "\n");
            }

            //--------------------------Total por dia-------------------------------------
            Console.WriteLine("=====Total por dia=====\n");
            for (int u = 0; u < arrayDias.Length; u++)
            {
                int sumaD = 0;
                for (int t = 0; t < arrayProductos.Length; t++)
                {
                    sumaD += ventas[t, u];
                }
                Console.WriteLine($"{arrayDias[u]}: " + sumaD + "\n");
            }

            //-----------------------------Producto lider------------------------------------
            Console.WriteLine("====Producto Lider====\n");
            int maxVentas = 0;
            int productoTop = 0;
            for (int q = 0; q < arrayProductos.Length; q++)
            {
                int sumaFila = 0;
                for (int g = 0; g < arrayDias.Length; g++)
                {
                    sumaFila += ventas[q, g];
                }
                if (sumaFila > maxVentas)
                {
                    maxVentas = sumaFila;
                    productoTop = q;
                }
            }
            Console.WriteLine($"El producto con mas ventas es {arrayProductos[productoTop]} con un total de: {maxVentas}" + "\n");

            //----------------------------Dia mas bajo----------------------------------------------------
            Console.WriteLine("======Dia con ventsa mas bajas=====\n");
            int minDia = 0;
            int minVentas = 0;

            for (int z = 0; z < arrayProductos.Length; z++)
            {
                minVentas += ventas[z, 0];
            }
            for (int x = 1; x < arrayDias.Length; x++)
            {
                int ventasDia = 0;

                for (int z = 0; z < arrayProductos.Length; z++)
                {
                    ventasDia += ventas[z, x];
                }

                if (ventasDia < minVentas)
                {
                    minVentas = ventasDia;
                    minDia = x;
                }
            }
            Console.WriteLine($"El día con menores ventas fue el {arrayDias[minDia]} con un total de: {minVentas}");
        }//cierre Main
    }
}
