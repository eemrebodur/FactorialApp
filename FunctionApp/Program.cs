using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi, FakToplam = 1;
            Console.Write("Faktöriyeli hesaplanacak sayı değerini giriniz = ");
            sayi = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < sayi; i++)
                FakToplam += FakToplam * i;
            Console.WriteLine(sayi + " sayısının faktoriyel sonucu = " + FakToplam);
            Console.ReadLine();

        }
    }
}
