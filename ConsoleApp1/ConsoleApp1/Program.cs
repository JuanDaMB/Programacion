using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program pr = new Program();
            int ejercicio = 0;
            Console.WriteLine("Hola \nPara mostrar las funciones, presione un número del 1 al 6");
            ejercicio = int.Parse(Console.ReadLine());
            
            switch (ejercicio)
            {
                case 1:
                    pr.Funcion1();
                    break;
                case 2:
                    pr.Funcion2();
                    break;
                case 3:
                    pr.Funcion3();
                    break;
                case 4:
                    pr.Funcion4();
                    break;
                case 5:
                    pr.Funcion5();
                    break;
                case 6:
                    pr.Funcion6();
                    break;
                default:
                    break;
            }
            Console.ReadKey();
        }
        void Funcion1()
        {
            int minutos;
            double costo;
            Console.WriteLine("Ingrese la cantidad de minutos");
            minutos = int.Parse(Console.ReadLine());
            if (minutos <= 3) { costo = 0.50f; Console.WriteLine("Costo: " + costo); }
            else { costo = (0.50f + (0.1f * (minutos - 3))); Console.WriteLine("Costo: " + costo); }
        }
        void Funcion2()
        {
            int numero, factorial = 0;
            Console.WriteLine("Ingrese un número");
            numero = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numero; i++)
            {
                factorial = factorial + i;
            }
            Console.WriteLine("La suma es: " + factorial);
        }
        void Funcion3()
        {
            int numero, factorial = 0;
            Console.WriteLine("Ingrese un número");
            numero = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numero; i++)
            {if (i % 3 == 0) {factorial = factorial + i; } }
            Console.WriteLine("La suma es: " + factorial);
        }
        void Funcion4()
        {
            int numero,diferencia,usuario, intento = 0;
            Random ran = new Random();
            numero = ran.Next(1, 11);
            //Console.WriteLine(numero + "\n");
            Console.WriteLine("Hola \nVamos a jugar un juego \nTendras que adivinar un numero \nAdelante, escribe un número");
            do
            {
                intento++;
                usuario = int.Parse(Console.ReadLine());
                diferencia = Math.Abs(numero - usuario);
                if (diferencia == 0) { Console.WriteLine("¡Ganaste!lo intentaste " + intento + "veces"); }
                else if (diferencia <= 3 && diferencia > 0) { Console.WriteLine("Caliente"); }
                else if (diferencia <= 6 && diferencia > 3) { Console.WriteLine("Tibio"); }
                else if (diferencia <= 9 && diferencia > 6) { Console.WriteLine("Frio"); }
                else if (diferencia >9) { Console.WriteLine("Heladisimo"); }
            } while (diferencia != 0);
        }
        void Funcion5()
        {
            int[] arr = new int[20];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Ingrese el número " + (i+1 )+":");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Los numeros menores o iguales a 25 son:");
            foreach (int num in arr)
            {if (num <= 25) { Console.WriteLine(num);}}
        }
        void Funcion6()
        {
            string[,] matrix = new string[20, 20];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = matrix.GetLength(1) - 1; j >= 0; j--)
                {
                    if (i == ((matrix.GetLength(1) - 1) - j))  { matrix[i, j] = "X"; }
                }
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if(i == j) {matrix[i, j] = "X";}
                    if (matrix[i,j] != "X")   { matrix[i, j] = "O"; }
                }
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {Console.Write(string.Format("{0} ", matrix[i, j])); }
                Console.Write("\n");
            }
        }
    }
}