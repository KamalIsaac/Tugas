using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 10;
            //var b = 6;

            Console.Write("Inputkan nilai a = ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Inputkan nilai b = ");
            var b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.Title = "Aplikasi calculator versi console";
            Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + Penambahan(a, b));
            Console.WriteLine("Hasil Penguranagan {0} - {1} = {2}", a, b,  Pengurangan(a, b));
            Console.WriteLine("Hasil Perkalian  {0} * {1} = {2}", a, b,  Perkalian(a, b));
            Console.WriteLine("Hasil Penambahan {0} / {1} = {2}", a, b,  Pembagian(a, b));

            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey();


        }
        static int Penambahan(int a, int b)
        {
            return a + b;
        }
        static int Pengurangan(int a, int b)
        {
            return a - b;
        }
        static int Pembagian(int a, int b)
        {
            return a / b;
        }

        static int Perkalian(int a, int b)
        {
            return a * b;
        }
    }
}
