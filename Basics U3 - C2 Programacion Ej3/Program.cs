using System;

namespace Basics_U3___C2_Programacion_Ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = Convert.ToInt32(Console.ReadLine());
            int Y = Convert.ToInt32(Console.ReadLine());
            double N = Convert.ToDouble(Console.ReadLine());
            double M = Convert.ToDouble(Console.ReadLine());
            

            Console.WriteLine("Variable X es "+X+", Variable Y es "+Y+", Variable N es " +N+ ", Variable M es "+M+"\n");
            Console.WriteLine("La Suma {0} + {1} = {2}\n",X,Y,X+Y);
            Console.WriteLine("La Diferencia {0} - {1} = {2}\n", X, Y, X - Y);
            Console.WriteLine("El Producto {0} * {1} = {2}\n", X, Y, X * Y);
            Console.WriteLine("El Cociente {0} / {1} = {2}\n", X, Y, X / Y);
            Console.WriteLine("El resto {0} % {1} = {2}\n", X, Y, X % Y);
            Console.WriteLine("La Suma {0} + {1} = {2}\n", N, M, N + M);
            Console.WriteLine("La Diferencia {0} - {1} = {2}\n", N, M, N - M);
            Console.WriteLine("El Producto {0} * {1} = {2}\n", N, M, N * M);
            Console.WriteLine("El Cociente {0} / {1} = {2}\n", N, M, N / M);
            Console.WriteLine("El resto {0} % {1} = {2}\n", N, M, N % M);
            Console.WriteLine("La Suma {0} + {1} = {2}\n", X, N, X + N);
            Console.WriteLine("El Cociente {0} / {1} = {2}\n", Y, M, Y / M);
            Console.WriteLine("El resto {0} % {1} = {2}\n", Y, M, Y % M);
            Console.WriteLine("El Doble de cada variable es  {0}, {1}, {2}, {3}\n", X*X, Y*Y, N*N, M*M);
            Console.WriteLine("El Producto de todas las variables es {0}\n", X*Y*N*M);


        }
    }
}
