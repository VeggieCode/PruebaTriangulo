using System;

namespace PruebaTriangulo
{
    class PruebaTriangulo
    {
        static void Main(string[] args)
        {
            int ladoA = 0;
            int ladoB = 0;
            int ladoC = 0;
            bool esValido = false;
            bool esTriangulo = false;
            string tipoTriangulo = "";
            bool enRango = false;

            while (!esValido || !esTriangulo || !enRango)
            {
                try
                {
                    Console.WriteLine("Ingrese lado A");
                    ladoA = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese lado B");
                    ladoB = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese lado C");
                    ladoC = Convert.ToInt32(Console.ReadLine());
                    esValido = true;
                    esTriangulo = esUnTriangulo(ladoA, ladoB, ladoC);
                    enRango = dentroDelRango(ladoA, ladoB, ladoC);

                    if (!esTriangulo)
                    {
                        Console.WriteLine("Los valores que se ingresaron no son los de un triángulo");
                    }
                    if (!enRango)
                    {
                        Console.WriteLine("Los valores no están dentro del rango definido");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("El dato que ingresaste no es un numero");
                }
            }

            if (ladoA == ladoB && ladoB == ladoC)
            {
                tipoTriangulo = "Equilátero";
            }
            else if (ladoA == ladoB || ladoA == ladoC || ladoC == ladoB)
            {
                tipoTriangulo = "Isósceles";
            }
            else
            {
                tipoTriangulo = "Escaleno";
            }
            Console.WriteLine("El triángulo es " + tipoTriangulo);
        }

        static bool esUnTriangulo(int ladoA, int ladoB, int ladoC)
        {
            bool esTriangulo = false;
            if ((ladoA + ladoB) > ladoC)
            {
                if ((ladoA + ladoC) > ladoB)
                {
                    if ((ladoB + ladoC) > ladoA)
                    {
                        esTriangulo = true;
                    }
                }
            }

            return esTriangulo;
        }
        static bool dentroDelRango(int ladoA, int ladoB, int ladoC)
        {
            bool enRango = false;
            if (ladoA >= 1 && ladoA <= 200)
            {
                if (ladoB >= 1 && ladoB <= 200)
                {
                    if (ladoC >= 1 && ladoB <= 200)
                    {
                        enRango = true;
                    }
                }
            }
            return enRango;
        }
    }
}
