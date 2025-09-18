using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace TiendaExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            //----------------------Vector inventario-----------------------
            Console.WriteLine("DEFINIR EL TAMAÑO DEL INVENTARIO: ");
            int size = int.Parse(Console.ReadLine()); 
            int[] codigoProducto = new int[size];
            //----------------------Llenar datos del vector-----------------
            for (int i = 0; i < codigoProducto.Length; i++)
            {
                Console.WriteLine("CODIGO DEL PRODUCTO VENDIDO: ");
                codigoProducto[i] = int.Parse(Console.ReadLine()); 
                Console.Clear();
            }
            Console.WriteLine("--------PRODUCTOS----------");
            foreach (int a in codigoProducto)
            {
                Console.WriteLine("CODIGO: D-" + a); 
            }
            Console.WriteLine();
            //--------------------Buscar--------------------------
            Console.WriteLine("CODIGO QUE DESEA BUSCAR: ");
            int buscar = int.Parse(Console.ReadLine());
            int count = 0;
            Console.WriteLine();
            for (int i = 0; i < codigoProducto.Length; i++)
            {
                if (codigoProducto[i] == buscar)
                {
                    count++;
                }
            }
            Console.Write("EL CODIGO " + buscar + " APARECE " + count + " VECES ");
            Console.WriteLine();
            //---------insertar--------
            Console.WriteLine("INSERTAR NUEVO CODIGO DEL PRODUCTO VENDIDO:");
            int newP = int.Parse(Console.ReadLine());
            int[] newCodigo = new int[codigoProducto.Length + 1];
            for (int j = 0; j < codigoProducto.Length; j++)
            {
                newCodigo[j] = codigoProducto[j];
                newCodigo[newCodigo.Length - 1] = newP;
            }
            Console.WriteLine("--------PRODUCTOS----------");
            foreach (int b in newCodigo)
            {
                Console.WriteLine(" CODIGO: D-" + b); 
            }
            Console.WriteLine();
            Console.WriteLine("--SE INSERTO EL CODIGO CORRECTAMENTE--");
            Console.WriteLine();
            //--------------------ELIMINAR---------------------
            Console.WriteLine("INGRESE EL CODIGO QUE DESEA ELIMINAR: ");
            int eliminar = int.Parse(Console.ReadLine());
            int[] eliminadoCodigo = new int[newCodigo.Length - 1];
            bool borrado = false;
            for (int k = 0, l = 0; k < newCodigo.Length; k++)
            {
                if (newCodigo[k] == eliminar && borrado == false)
                {
                    borrado = true; 
                }
                else
                {
                    eliminadoCodigo[l] = newCodigo[k];
                    l++;
                }
            }
            Console.WriteLine("--------PRODUCTOS----------");
            foreach (int c in eliminadoCodigo)
            {
                Console.WriteLine(" CODIGO: D-" + c);
            }
            Console.WriteLine();
            Console.WriteLine("SE ELIMINO EL CODIGO CORRECTAMENTE");
        }
    }
}