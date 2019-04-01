using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOrdenar
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] numeros = new int[10];
            int numerosIngresados = 0;
            int mayor = numeros[0];
            int menor = numeros[0];
            double promedio = 0;
            double suma = 0;

            do
            {
                Console.Write("Ingrese un número " + (numerosIngresados + 1) + " : ");
                string linea;
                linea = Console.ReadLine();
                numeros[numerosIngresados] = int.Parse(linea);
                numerosIngresados++;

            } while (numerosIngresados < 10);

            for (int contador = numeros.Length - 1; contador >= 0; contador--)
            {
                Console.WriteLine(numeros[contador]);
            }

            for (int x = 0; x < 10; x++)
            {
                if (numeros[x] > mayor)
                    mayor = numeros[x];

                if (numeros[x] < menor)
                    menor = numeros[x];
            }

            for (int i = 1; i < numeros.Length; i++)
            {
                suma = suma + numeros[i];
            } 
            promedio = suma / numeros.Length;

            Console.WriteLine("El mayor de los números ingresados es : " + mayor);
            Console.WriteLine("El menor de los números ingresados es : " + menor);
            Console.WriteLine("El promedio de los numeros ingresados es : " + promedio);
        }
    }
}
